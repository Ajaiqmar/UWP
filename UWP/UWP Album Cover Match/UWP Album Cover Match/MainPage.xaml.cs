using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UWP_Album_Cover_Match.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Album_Cover_Match
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        internal bool RestTime = false;
        internal int GameRounds = 1;
        internal int GameScore = 0;
        internal Song SelectedSong = null;
        internal List<StorageFile> AllSongs;
        internal ObservableCollection<Song> GameSongs;

        public MainPage()
        {
            this.InitializeComponent();
            AllSongs = new List<StorageFile>();
            GameSongs= new ObservableCollection<Song>();
        }

        private async void OnPageLoad(object sender, RoutedEventArgs e)
        {
            await this.GetAllSongsFromMusicLibrary(KnownFolders.MusicLibrary);
            await this.LoadGame();
        }

        private async void OnAnimationComplete(object sender, object e)
        {
            await this.PlayCurrentGameState();
        }
        
        internal async Task PlayCurrentGameState()
        {
            if (RestTime)
            {
                if (GameRounds == 6 || SelectedSong != null)
                {
                    this.EndGame();
                    return;
                }

                SongPlayer.Stop();
                GameStateDescription.Text = $"Get ready for Round {GameRounds} ...";
                GameRounds++;
            }
            else
            {
                bool gotSong = false;
                Random r = new Random();

                while (!gotSong)
                {
                    int t = r.Next(GameSongs.Count);

                    if (!GameSongs[t].IsSelected)
                    {
                        gotSong = !gotSong;
                        SelectedSong = GameSongs[t];
                        GameSongs[t].IsSelected = true;
                    }
                }

                SongPlayer.SetSource(await SelectedSong.SongFile.OpenAsync(FileAccessMode.Read), SelectedSong.SongFile.ContentType);
                SongPlayer.Play();

                GameStateDescription.Text = "Go!!";
            }

            RestTime = !RestTime;
            TimerAnimation.Begin();
        }

        internal async Task GetAllSongsFromMusicLibrary(StorageFolder root)
        {
            foreach (StorageFile file in await root.GetFilesAsync())
            {
                if(file.FileType.Equals(".mp3"))
                AllSongs.Add(file);
            }

            foreach(StorageFolder folder in await root.GetFoldersAsync())
            {
                await this.GetAllSongsFromMusicLibrary(folder);
            }
        }

        internal async Task<List<Song>> GetRandomSongs()
        {
            Random r = new Random();
            List<Song> randomSongs = new List<Song>();

            while(randomSongs.Count < 10)
            {
                int t = r.Next(AllSongs.Count);
                StorageFile storageFile = AllSongs[t];
                MusicProperties music = await storageFile.Properties.GetMusicPropertiesAsync();

                bool flag = true;

                foreach(Song song in randomSongs)
                {
                    if(song.SongAlbumIn.Equals(music.Album))
                    {
                        flag = false;
                        break;
                    }
                }

                if(flag)
                {
                    StorageItemThumbnail thumbnail = await storageFile.GetThumbnailAsync(ThumbnailMode.MusicView,200,ThumbnailOptions.UseCurrentScale);
                    BitmapImage image = new BitmapImage();
                    image.SetSource(thumbnail);

                    randomSongs.Add(new Song { SongId = randomSongs.Count + 1, SongName = music.Title, SongAlbumIn = music.Album, SongPerformedBy = music.Artist, SongThumbnail = image, SongFile = storageFile, IsSelected = false });
                }
            }

            return randomSongs;
        }


        internal async Task LoadGame()
        {
            GameRounds = 1;
            GameScore = 0;
            RestTime = false;
            ReplayButton.Visibility = Visibility.Collapsed;

            TimerAnimation.Begin();
            GameStateDescription.Text = $"Get ready for Round {GameRounds} ...";
            GameRounds++;

            GameSongs.Clear();

            List<Song> randomSongs = await this.GetRandomSongs();

            foreach (Song song in randomSongs)
            {
                GameSongs.Add(song);
            }
        }

        private async void GameRestart(object sender, RoutedEventArgs e)
        {
            await this.LoadGame();
        }

        private async void OnSongSelect(object sender, ItemClickEventArgs e)
        {
            if(RestTime)
            {
                Song selectedSong = e.ClickedItem as Song;

                if (SelectedSong.SongName.Equals(selectedSong.SongName))
                {
                    StorageFile storageFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri(this.BaseUri, "/Assets/correct.png"));
                    var fileStream = await storageFile.OpenAsync(FileAccessMode.Read);
                    await selectedSong.SongThumbnail.SetSourceAsync(fileStream);

                    GameScore += 100;

                    TotalScore.Text = $"Total Score After {GameRounds-1} : {GameScore}";
                    CorrectSong.Text = $"Correct Song : {SelectedSong.SongName}";
                    PerformedBy.Text = $"Performed By : {SelectedSong.SongPerformedBy}";
                    InAlbum.Text = $"On Album : {SelectedSong.SongAlbumIn}";
                }
                else
                {
                    StorageFile storageFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri(this.BaseUri, "/Assets/incorrect.png"));
                    var fileStream = await storageFile.OpenAsync(FileAccessMode.Read);
                    await selectedSong.SongThumbnail.SetSourceAsync(fileStream);

                    GameScore -= 100;

                    TotalScore.Text = $"Total Score After {GameRounds - 1} : {GameScore}";
                    CorrectSong.Text = $"Correct Song : {SelectedSong.SongName}";
                    PerformedBy.Text = $"Performed By : {SelectedSong.SongPerformedBy}";
                    InAlbum.Text = $"On Album : {SelectedSong.SongAlbumIn}";
                }

                SelectedSong = null;
                await this.PlayCurrentGameState();
            }
        }

        internal void EndGame()
        {
            SongPlayer.Stop();
            TimerAnimation.Stop();
            GameStateDescription.Text = $"Game Over... You scored : {GameScore}";
            ReplayButton.Visibility = Visibility.Visible;
            TotalScore.Text = "";
            CorrectSong.Text = "";
            PerformedBy.Text = "";
            InAlbum.Text = "";
        }
    }
}

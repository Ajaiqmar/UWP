using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Core;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using HeroExplorer.Models;
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPHeroExplorer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        internal const string PUBLIC_API_KEY = "47ca9d17389e516b5cf0a3728eb4ca7f";
        internal const string PRIVATE_API_KEY = "b312c853df70e22b32d6c691de5593c4000b84e7";
        internal ObservableCollection<Character> CharactersList;
        internal ObservableCollection<ComicBook> ComicList;

        public MainPage()
        {
            this.InitializeComponent();
            CharactersList = new ObservableCollection<Character>();
            ComicList= new ObservableCollection<ComicBook>();
        }

        private async void OnCharacterSelect(object sender, ItemClickEventArgs e)
        {
            Character selectedCharacter = e.ClickedItem as Character;
            CharacterDescription.Visibility= Visibility.Visible;
            ComicGridProgressRing.IsActive = true;
            ComicTemplate.Visibility= Visibility.Collapsed;

            CharacterDescriptionImage.Source = new BitmapImage(new Uri(selectedCharacter.thumbnail.large,UriKind.Absolute));
            CharacterDescriptionName.Text = selectedCharacter.name;

            await PopulateComicList(selectedCharacter);
        }

        internal string GetTimeStamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }

        internal string GetHash(string PlainText)
        {
            var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buff = CryptographicBuffer.ConvertStringToBinary(PlainText, BinaryStringEncoding.Utf8);
            var hashed = alg.HashData(buff);
            var res = CryptographicBuffer.EncodeToHexString(hashed);

            return res;
        }

        internal async Task PopulateComicList(Character SelectedCharacter)
        {
            ComicList.Clear();

            var timeStamp = this.GetTimeStamp();
            var hash = GetHash(timeStamp + PRIVATE_API_KEY + PUBLIC_API_KEY);

            var url = $"http://gateway.marvel.com:80/v1/public/comics?characters={SelectedCharacter.id}&limit=20&ts={timeStamp}&apikey={PUBLIC_API_KEY}&hash={hash}";

            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(ComicDataWrapper));
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(responseString));

            ComicDataWrapper comics = serializer.ReadObject(memoryStream) as ComicDataWrapper;

            foreach (var comic in comics.data.results)
            {
                if (comic.thumbnail != null && comic.thumbnail.path != "" && comic.thumbnail.path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
                {
                    comic.thumbnail.large = String.Format("{0}/portrait_xlarge.{1}",
                        comic.thumbnail.path,
                        comic.thumbnail.extension);

                    comic.ImageSource = new BitmapImage(new Uri(comic.thumbnail.large));

                    ComicList.Add(comic);
                }
            }

            ComicGridProgressRing.IsActive = false;
        }

        internal async Task PopulateCharacterList()
        {
            CharactersList.Clear();

            var timeStamp = this.GetTimeStamp();
            var hash = GetHash(timeStamp + PRIVATE_API_KEY + PUBLIC_API_KEY);

            var url = $"https://gateway.marvel.com/v1/public/characters?ts={timeStamp}&apikey={PUBLIC_API_KEY}&hash={hash}";

            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(responseString));

            CharacterDataWrapper characters = serializer.ReadObject(memoryStream) as CharacterDataWrapper;

            foreach(var character in characters.data.results)
            {
                if(character.thumbnail != null && character.thumbnail.path != "" && character.thumbnail.path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
                {
                    character.thumbnail.small = String.Format("{0}/standard_small.{1}",
                            character.thumbnail.path,
                            character.thumbnail.extension);

                    character.thumbnail.large = String.Format("{0}/portrait_xlarge.{1}",
                        character.thumbnail.path,
                        character.thumbnail.extension);

                    character.ImageSource = new BitmapImage(new Uri(character.thumbnail.small));

                    CharactersList.Add(character);
                }
            }

            CharacterListProgressRing.IsActive = false;
        }

        private async void OnPageLoad(object sender, RoutedEventArgs e)
        {
            await PopulateCharacterList();
        }

        private void OnComicSelect(object sender, ItemClickEventArgs e)
        {
            ComicBook comic = e.ClickedItem as ComicBook;
            ComicTemplate.Visibility = Visibility.Visible;

            ComicImage.Source = comic.ImageSource;
            ComicName.Text = comic.title;

            if(comic.description != null)
            {
                ComicDescription.Text = comic.description;
            }
            else
            {
                ComicDescription.Text = "";
            }
        }
    }
}

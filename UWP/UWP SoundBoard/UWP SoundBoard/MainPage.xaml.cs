using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_SoundBoard.Models;
using Windows.Media.Playback;
using Windows.Media.Core;
using Windows.Devices.Radios;
using Windows.Storage;
using System.Net.Mime;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_SoundBoard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        internal ObservableCollection<Sound> Sounds;
        internal List<Sound> AllSounds;

        public MainPage()
        {
            this.InitializeComponent();
            Sounds = new ObservableCollection<Sound>();
            AllSounds = Sound.GetSounds();

            foreach(var sound in AllSounds)
            {
                Sounds.Add(sound);
            }
        }

        private void OpenPane(object sender, RoutedEventArgs e)
        {
            SoundSplitView.IsPaneOpen = !SoundSplitView.IsPaneOpen;
        }

        private void OnNavigationSelect(object sender, SelectionChangedEventArgs e)
        {
            if (AnimalsListBox.IsSelected)
            {
                SoundsHeader.Text = "Animals";
                ExitButton.Visibility = Visibility.Visible;

                Sounds.Clear();

                foreach (var sound in AllSounds)
                {
                    if(sound.AudType == AudioType.ANIMALS)
                    {
                        Sounds.Add(sound);
                    }
                }
            }
            else if(CartoonListBox.IsSelected)
            {
                SoundsHeader.Text = "Cartoons";
                ExitButton.Visibility = Visibility.Visible;

                Sounds.Clear();

                foreach (var sound in AllSounds)
                {
                    if (sound.AudType == AudioType.CARTOONS)
                    {
                        Sounds.Add(sound);
                    }
                }
            }
            else if(TauntsListBox.IsSelected)
            {
                SoundsHeader.Text = "Taunts";
                ExitButton.Visibility = Visibility.Visible;

                Sounds.Clear();

                foreach (var sound in AllSounds)
                {
                    if (sound.AudType == AudioType.TAUNTS)
                    {
                        Sounds.Add(sound);
                    }
                }
            }
            else if(WarningListBox.IsSelected)
            {
                SoundsHeader.Text = "Warnings";
                ExitButton.Visibility = Visibility.Visible;

                Sounds.Clear();

                foreach (var sound in AllSounds)
                {
                    if (sound.AudType == AudioType.WARNINGS)
                    {
                        Sounds.Add(sound);
                    }
                }
            }
        }

        private void ExitToAllSounds(object sender, RoutedEventArgs e)
        {
            ExitButton.Visibility = Visibility.Collapsed;
            SoundsHeader.Text = "All Sounds";
            SoundGenreListBox.SelectedItem = null;

            Sounds.Clear();

            foreach (var sound in AllSounds)
            {
                Sounds.Add(sound);
            }
        }

        private void OnTextEnter(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            Sounds.Clear();
            ExitButton.Visibility = Visibility.Collapsed;

            List<string> suggestions = new List<string>();

            foreach (var sound in AllSounds)
            {
                if(sound.AudioDescription.ToLower().StartsWith(sender.Text.ToLower()))
                {
                    suggestions.Add(sound.AudioDescription);
                    Sounds.Add(sound);
                }
            }

            if(suggestions.Count == 0)
            {
                SoundsHeader.Text = "All Sounds";

                foreach (var sound in AllSounds)
                {
                    Sounds.Add(sound);
                }
            }
            else
            {
                if(sender.Text.Equals(""))
                {
                    SoundsHeader.Text = "All Sounds";
                }
                else
                {
                    SoundsHeader.Text = sender.Text;
                }
            }

            SoundSearchBox.ItemsSource = suggestions;
        }

        private void OnQuerySubmit(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            foreach (var sound in AllSounds)
            {
                if (sound.AudioDescription.ToLower().Equals(sender.Text.ToLower()))
                {
                    Sounds.Clear();
                    Sounds.Add(sound);

                    SoundsHeader.Text = sound.AudioDescription;
                    ExitButton.Visibility = Visibility.Visible;
                }
            }
        }

        private void OnSoundClick(object sender, ItemClickEventArgs e)
        {
            var sound = (Sound)e.ClickedItem;
            AudioPlayer.Source = new Uri(this.BaseUri,sound.AudioSource);
        }

        private async void DropTheAudio(object sender, DragEventArgs e)
        {
            IReadOnlyList<IStorageItem> files = await e.DataView.GetStorageItemsAsync();
            StorageFile file = files.First() as StorageFile;

            if (file.ContentType == "audio/wav" || file.ContentType == "audio/mpeg")
            {
                AudioPlayer.SetSource(await file.OpenAsync(FileAccessMode.Read), file.ContentType);
                AudioPlayer.Play();
            }
        }

        private void OnDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Copy;

            e.DragUIOverride.Caption = "Drop to listen";
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;
        }
    }
}

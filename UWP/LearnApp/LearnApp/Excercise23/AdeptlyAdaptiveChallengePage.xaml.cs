using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LearnApp.Excercise23.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnApp.Excercise23
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdeptlyAdaptiveChallengePage : Page
    {
        internal ObservableCollection<NewsItem> Items;
        internal List<NewsItem> AllItems;
        public AdeptlyAdaptiveChallengePage()
        {
            this.InitializeComponent();

            AllItems = NewsItem.GetNewsItems();
            Items = new ObservableCollection<NewsItem>();

            foreach (var item in AllItems)
            {
                if (item.NewsCategory == Category.FINANCIAL)
                {
                    Items.Add(item);
                }
            }
        }

        private void OpenPane(object sender, RoutedEventArgs e)
        {
            NewsSplitView.IsPaneOpen = !NewsSplitView.IsPaneOpen;
        }

        private void OnNavigationSelect(object sender, SelectionChangedEventArgs e)
        {
            var listBox = sender as ListBox;
            var listBoxItem = listBox.SelectedItem as ListBoxItem;

            Header.Text = listBoxItem.Name;
            
            if(Header.Text.Equals("Financial"))
            {
                Items.Clear();

                foreach(var item in AllItems)
                {
                    if(item.NewsCategory == Category.FINANCIAL)
                    {
                        Items.Add(item);
                    }
                }
            }
            else
            {
                Items.Clear();

                foreach (var item in AllItems)
                {
                    if (item.NewsCategory == Category.FOOD)
                    {
                        Items.Add(item);
                    }
                }
            }
        }
    }
}

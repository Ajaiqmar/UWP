using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnApp.Excercise13
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HamburgerNavigationPageChallenge : Page
    {
        public HamburgerNavigationPageChallenge()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(FinancialPage));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(FinancialPage));
            HeaderTextBlock.Text = "Finance";
            BackButton.Visibility = Visibility.Collapsed;

            foreach(ListBoxItem lbi in MyListBox.SelectedItems)
            {
                lbi.IsSelected = false;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyListBox.SelectedItem != null)
            {
                ListBoxItem lbi = (ListBoxItem)MyListBox.SelectedItem;
                StackPanel sp = (StackPanel)lbi.Content;

                if (sp.Name.CompareTo("FinancialPanel") == 0)
                {
                    HeaderTextBlock.Text = "Finance";
                    BackButton.Visibility = Visibility.Collapsed;
                    MyFrame.Navigate(typeof(FinancialPage));
                }
                else
                {
                    HeaderTextBlock.Text = "Food";
                    BackButton.Visibility = Visibility.Visible;
                    MyFrame.Navigate(typeof(FoodPage));
                }

                MySplitView.IsPaneOpen = false;
            }
        }
    }
}

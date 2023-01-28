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

namespace LearnApp.Excercise14
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MoreXAMLControlParts : Page
    {
        string[] names = { "Ajay Kumar", "Dinesh", "Devi Prasad", "Vasanth", "Shriniwaaz" };

        public MoreXAMLControlParts()
        {
            this.InitializeComponent();
        }

        private void MyCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            CalendarView c = (CalendarView)sender;
            string temp = "";

            foreach (var date in c.SelectedDates)
            {
                temp += $"{date.Month}/{date.Day}, ";
            }

            MyCalendarViewResult.Text = temp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            List<string> filteredNames = new List<string>();

            foreach (string name in names)
            {
                if (name.StartsWith(MyAutoSuggestBox.Text))
                {
                    filteredNames.Add(name);
                }
            }

            MyAutoSuggestBox.ItemsSource = filteredNames;
        }

        private void OnPasswordChange(object sender, RoutedEventArgs e)
        {
            PasswordBox pb = (PasswordBox)sender;
            PasswordBoxResult.Text = pb.Password;

        }
    }
}

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
using LearnApp.Excercise22.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnApp.Excercise22
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ObservableCollectionPage : Page
    {
        internal ObservableCollection<Contact> Contacts;
        public ObservableCollectionPage()
        {
            this.InitializeComponent();
            Contacts = new ObservableCollection<Contact>();
        }

        private void AddContact(object sender, RoutedEventArgs e)
        {
            if (!FirstName.Text.Equals("") && !LastName.Text.Equals("") && MyComboBox.SelectedItem != null)
            {
                var boxItem = MyComboBox.SelectedItem as ComboBoxItem;
                var boxItemName = boxItem.Name;
                string avatarPath;

                switch(boxItemName)
                {
                    case "m1":
                        avatarPath = "../Assets/male-01.png";
                        break;
                    case "m2":
                        avatarPath = "../Assets/male-02.png";
                        break;
                    case "m3":
                        avatarPath = "../Assets/male-03.png";
                        break;
                    case "f1":
                        avatarPath = "../Assets/female-01.png";
                        break;
                    case "f2":
                        avatarPath = "../Assets/female-02.png";
                        break;
                    default:
                        avatarPath = "../Assets/female-03.png";
                        break;
                }

                Contacts.Add(new Contact { FirstName = FirstName.Text, LastName = LastName.Text, Name = (FirstName.Text + " " + LastName.Text), Avatar = avatarPath});
            }
        }
    }
}

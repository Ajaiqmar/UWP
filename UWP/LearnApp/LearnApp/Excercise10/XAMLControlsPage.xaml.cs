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

namespace LearnApp.Excercise10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class XAMLControlsPage : Page
    {
        public XAMLControlsPage()
        {
            this.InitializeComponent();
        }

        private void OnCheck(object sender, RoutedEventArgs e)
        {
            CheckBoxResult.Text = (((bool)MyCheckBox.IsChecked)?"Yes":"No");
        }

        private void OnRadioCheck(object sender, RoutedEventArgs e)
        {
            RadioButton component = (RadioButton)sender;
            RadioButtonResult.Text = (string)component.Content;
        }

        private void OnSelect(object sender, SelectionChangedEventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            ComboBoxItem i = (ComboBoxItem)c.SelectedItem;
            ComboBoxResult.Text = (string)i.Content;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            var arr = lb.SelectedItems;

            string temp = "";

            foreach(ListBoxItem lbi in arr)
            {
                temp += $"{(string)lbi.Content},";
            }

            ListBoxResult.Text = temp;
        }

        private void OnToggle(object sender, RoutedEventArgs e)
        {
            ToggleButtonResult.Text = ((bool)MyToggle.IsChecked)?"Yes":"No";
        }

        private void OnTap(object sender, RoutedEventArgs e)
        {
            ToggleSwitchResult.Text = ((bool)MyToggleSwitch.IsOn) ? "On" : "Off";
        }
    }
}

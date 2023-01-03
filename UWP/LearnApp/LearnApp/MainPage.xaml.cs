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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LearnApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private void OnClick(object sender, RoutedEventArgs e)
        //{
        //    MySpliView.IsPaneOpen = !MySpliView.IsPaneOpen;
        //}

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

        /*private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Button b = new Button();
            b.Content = "Click Me";
            b.HorizontalAlignment= HorizontalAlignment.Center;

            LayoutGrid.Children.Add(b);
        }*/

        /*private void OnClick(object sender, RoutedEventArgs e)
        {
            HeaderBlock.Text = "HELLO AJAY";
        }*/
    }
}

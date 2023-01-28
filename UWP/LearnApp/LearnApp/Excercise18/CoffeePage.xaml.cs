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

namespace LearnApp.Excercise18
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void OnRoastSelect(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem m = (MenuFlyoutItem)sender;

            if(m.Text.Equals("None"))
            {
                RoastDescription.Text = "";
                CreamDescription.Text = "";
                SweetenerDescription.Text = "";
            }
            else
            {
                RoastDescription.Text = m.Text;
            }
        }

        private void OnSweetenerSelect(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem m = (MenuFlyoutItem)sender;

            if (m.Text.Equals("None") && !RoastDescription.Text.Equals(""))
            {
                SweetenerDescription.Text = "";
            }
            else if(!RoastDescription.Text.Equals(""))
            {
                SweetenerDescription.Text = $"+ {m.Text}";
            }
        }

        private void OnCreamSelect(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem m = (MenuFlyoutItem)sender;

            if (m.Text.Equals("None") && !RoastDescription.Text.Equals(""))
            {
                CreamDescription.Text = "";
            }
            else if (!RoastDescription.Text.Equals(""))
            {
                CreamDescription.Text = $"+ {m.Text}";
            }
        }
    }
}

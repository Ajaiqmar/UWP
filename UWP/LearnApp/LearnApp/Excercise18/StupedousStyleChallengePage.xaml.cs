using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class StupedousStyleChallengePage : Page
    {
        public StupedousStyleChallengePage()
        {
            this.InitializeComponent();
            NavigationFrame.Navigate(typeof(DonutPage));
        }

        private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Button b = sender as Button;
            b.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void Button_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Button b = sender as Button;
            b.BorderThickness = new Thickness(0, 0, 2, 0);
        }

        private void GetDonutPage(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(typeof(DonutPage));
        }

        private void GetCoffeePage(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(typeof(CoffeePage));
        }

        private void GetSchedulePage(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(typeof(SchedulePage));
        }

        private void GetCompletePage(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(typeof(CompletePage));
        }
    }
}

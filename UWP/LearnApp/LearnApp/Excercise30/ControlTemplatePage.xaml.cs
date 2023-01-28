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

namespace LearnApp.Excercise30
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ControlTemplatePage : Page
    {
        internal string ButtonText = "&#xE708;";
        public ControlTemplatePage()
        {
            this.InitializeComponent();
        }

        private void OnPointerEnter(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(sender as Button, "MouseOver", true);
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(sender as Button, "Pressed", true);
            if (this.RequestedTheme == ElementTheme.Light || this.RequestedTheme == ElementTheme.Default)
            {
                this.RequestedTheme = ElementTheme.Dark;
                MyButton.Content = "\uE706";
            }
            else
            {
                this.RequestedTheme = ElementTheme.Light;
                MyButton.Content = "\uE708";
            }
        }

        private void OnPointerExit(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(sender as Button, "Normal", true);
        }

        private void OnAnimationComplete(object sender, object e)
        {
            VisualStateManager.GoToState(MyButton, "MouseOver", true);
        }
    }
}

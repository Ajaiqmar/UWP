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

namespace LearnApp.Excercise25
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LazyLoadingPage : Page
    {
        public LazyLoadingPage()
        {
            this.InitializeComponent();
        }

        // This is used by the bindings between the rectangles and check box.
        private bool Not(bool? value) { return !(value == true); }

        private void LoadElements_Click(object sender, RoutedEventArgs e)
        {
            // This will load the deferred grid, but not the nested
            // rectangles that have x:Load attributes.
            this.FindName("DeferredGrid");
        }

        private void UnloadElements_Click(object sender, RoutedEventArgs e)
        {
            // This will unload the grid and all its child elements.
            this.UnloadObject(DeferredGrid);
        }
    }
}

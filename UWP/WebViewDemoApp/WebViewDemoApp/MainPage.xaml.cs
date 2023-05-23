using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebViewDemoApp
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await MyWebview.ExecuteScriptAsync("document.getElementById('Result').innerHTML = 'Hello '+document.getElementById('NameInputField').value;");
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var storageFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Web/HTML/index.html"));
            MyWebview.Source = new Uri(storageFile.Path);
            MyWebview.WebMessageReceived += MessageHandler;
        }

        private void MessageHandler(object s, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string clipboardText = e.TryGetWebMessageAsString();

            if(clipboardText.Equals("Saved"))
            {
                MyButton.Content = "Saved";
            }
        }
    }
}

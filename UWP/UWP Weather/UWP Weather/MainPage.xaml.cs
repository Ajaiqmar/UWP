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
using UWP_Weather;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Weather
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

        private async void OnPageLoad(object sender, RoutedEventArgs e)
        {
            Root r = await WeatherAPI.GetWeatherData();

            if(r != null)
            {
                WeatherRepresentation.Source = new BitmapImage(new Uri(this.BaseUri, $"/Assets/Weather/{r.weather[0].icon}.png"));
                Temperature.Text = $"{r.main.temp}";
                WeatherDescription.Text = $"{r.weather[0].description}";
                Location.Text = $"{r.name}";
            }
            else
            {
                Temperature.Text = "Data Unavailable";
                WeatherRepresentation.Visibility = Visibility.Collapsed;
                WeatherDescription.Visibility = Visibility.Collapsed;
                Location.Visibility = Visibility.Collapsed;
            }

            MyProgressRing.Visibility = Visibility.Collapsed;

            var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text01);

            // You will need to look at the template documentation to know how many text fields a particular template has.
            // Get the text attribute for this template and fill it in.
            var tileAttributes = tileXml.GetElementsByTagName("text");
            tileAttributes[0].AppendChild(tileXml.CreateTextNode($"{r.main.temp}"));
            tileAttributes[1].AppendChild(tileXml.CreateTextNode(r.weather[0].description));

            // Create the notification from the XML.
            var tileNotification = new TileNotification(tileXml);

            // Send the notification to the calling app's tile.
            var temp = TileUpdateManager.CreateTileUpdaterForApplication();
            temp.EnableNotificationQueue(true);
            temp.Clear();
            temp.Update(tileNotification);
        }
    }
}

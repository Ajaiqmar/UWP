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
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GalleryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public class ImagePanel : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach(var child in Children)
            {
                child.Measure(new Size(100,100));
            }
            return availableSize;
        }

 

        protected override Size ArrangeOverride(Size finalSize)
        {
            double middleOfTheScreenX = (Window.Current.Bounds.Width / 2.0) - 50,middleOfTheScreenY = (Window.Current.Bounds.Height / 2.0) - 50;
            double numberOfPointsInCircle = 6.0;
            int numberOfPointsCovered = 0;
            double newX = middleOfTheScreenX;
            double newY = middleOfTheScreenY;
            int countOfChildren = 1;
            int radius = 110;
            double slice = (Math.PI * 2) / numberOfPointsInCircle;

            Children[0].Arrange(new Rect(new Point(middleOfTheScreenX, middleOfTheScreenY), Children[0].DesiredSize));

            while(countOfChildren < Children.Count)
            {
                double angle = slice * numberOfPointsCovered;
                numberOfPointsCovered += 1;

                newX = (middleOfTheScreenX + radius * Math.Cos(angle));
                newY = (middleOfTheScreenY + radius * Math.Sin(angle));

                Children[countOfChildren].Arrange(new Rect(new Point(newX, newY), Children[countOfChildren].DesiredSize));
                countOfChildren += 1;

                if(numberOfPointsCovered == (int)numberOfPointsInCircle)
                {
                    numberOfPointsInCircle += 6.0;
                    slice = (Math.PI * 2) / numberOfPointsInCircle;
                    radius += 110;
                    numberOfPointsCovered = 0;
                }
            }

            return finalSize;
        }
    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnPointerEnter(object sender, PointerRoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse { Style = this.Resources["ImageStyle"] as Style };
            MyImagePanel.Children.Add(ellipse);
        }
    }
}

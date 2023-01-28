using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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

namespace LearnApp.Excercise26
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public class BoxPanel : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach(var child in Children)
            {
                var element = child as FrameworkElement;

                if(element != null && Double.IsNaN(element.Width) && element.HorizontalAlignment == HorizontalAlignment.Stretch)
                {
                    element.Width = availableSize.Width;
                    element.Measure(availableSize);
                }
                else if(element != null)
                {
                    child.Measure(availableSize);
                }
            }

            return availableSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            int y = 0;

            foreach(var child in Children)
            {
                child.Arrange(new Rect(new Point(0,y),child.DesiredSize));
                y += 150;
            }

            return finalSize;
        }

    }

    public class SidePanel : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach(var child in Children)
            {
                child.Measure(availableSize);
            }

            return availableSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            int y = 0;
            bool flag = true;

            foreach(var child in Children)
            {
                var element = child as FrameworkElement;

                if (flag)
                {
                    child.Arrange(new Rect(new Point(0, y), child.DesiredSize));
                }
                else
                {
                    child.Arrange(new Rect(new Point(finalSize.Width - element.Width, y), child.DesiredSize));
                }

                flag = !flag;
                y += 100;
            }

            return finalSize;
        }
    }

    public sealed partial class CustomPanelPage : Page
    {
        public CustomPanelPage()
        {
            this.InitializeComponent();
        }

        private void AddRectangle(object sender, RoutedEventArgs e)
        {
            MySidePanel.Children.Add(new Grid { Background = new SolidColorBrush(Colors.Red), Width = 100, Height = 100 });
        }
    }
}

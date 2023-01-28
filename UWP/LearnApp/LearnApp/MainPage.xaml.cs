using LearnApp.Excercise1;
using LearnApp.Excercise10;
using LearnApp.Excercise11;
using LearnApp.Excercise12;
using LearnApp.Excercise13;
using LearnApp.Excercise14;
using LearnApp.Excercise15;
using LearnApp.Excercise16;
using LearnApp.Excercise17;
using LearnApp.Excercise18;
using LearnApp.Excercise19;
using LearnApp.Excercise2;
using LearnApp.Excercise20;
using LearnApp.Excercise21;
using LearnApp.Excercise22;
using LearnApp.Excercise23;
using LearnApp.Excercise24;
using LearnApp.Excercise25;
using LearnApp.Excercise26;
using LearnApp.Excercise3;
using LearnApp.Excercise4;
using LearnApp.Excercise5;
using LearnApp.Excercise6;
using LearnApp.Excercise7;
using LearnApp.Excercise8;
using LearnApp.Excercise9;
using LearnApp.Excercise27;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LearnApp.Excercise28;
using LearnApp.Excercise29;
using LearnApp.Excercise30;
using LearnApp.Excercise31;
using LearnApp.Excercise32;
using LearnApp.Excercise33;
using LearnApp.Excercise34;

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

        private async void OpenExcercise1(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(HelloWorldPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise3(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(GridPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise2(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(ProceduralComponentCreation));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise4(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(StackPanelPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise5(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(LaudableLayoutChallengePage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise6(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(LegendaryLayoutChallengePage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise7(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(LaboriousLayouChallengePage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise8(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(RelativePanelPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise9(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(SplitPanelPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise10(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(XAMLControlsPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise11(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(NavigationPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise12(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(HamburgerNavigationPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise13(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(HamburgerNavigationPageChallenge));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise14(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(MoreXAMLControlParts));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise15(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(CanvasPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise16(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(XAMLStylesPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise17(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(XAMLThemeResource));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise18(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(StupedousStyleChallengePage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise19(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(VisualStateManagerPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise20(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(AdaptiveLayoutPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise21(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(DataBindingPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise22(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(ObservableCollectionPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise23(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(AdeptlyAdaptiveChallengePage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise24(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(DragAndDropPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise25(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(LazyLoadingPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise26(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(CustomPanelPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise27(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(FilePickerPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise28(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(VariableSizedWrapGridPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise29(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(MenuPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise30(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(ControlTemplatePage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise31(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(StateTriggersPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise32(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(NotifyPropertyChangedPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow,frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise33(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(DependencyPropertyPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }

        private async void OpenExcercise34(object sender, RoutedEventArgs e)
        {
            AppWindow appWindow = await AppWindow.TryCreateAsync();
            Frame frame = new Frame();
            frame.Navigate(typeof(TemplatedControlPage));
            ElementCompositionPreview.SetAppWindowContent(appWindow, frame);
            await appWindow.TryShowAsync();
        }
    }
}

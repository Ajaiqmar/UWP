using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnApp.Excercise24
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DragAndDropPage : Page
    {
        public DragAndDropPage()
        {
            this.InitializeComponent();
        }

        private void OnDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Copy;
            e.DragUIOverride.Caption = "Drop the Image";
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;
        }

        private async void OnDrop(object sender, DragEventArgs e)
        {
            var fileItems = await e.DataView.GetStorageItemsAsync();

            var file = fileItems.First() as StorageFile;

            if(file.ContentType.Equals("image/png") || file.ContentType.Equals("image/jpeg") || file.ContentType.Equals("image/gif") || file.ContentType.Equals("image/webp"))
            {
                var bitImage = new BitmapImage();
                bitImage.SetSource(await file.OpenAsync(FileAccessMode.Read));
                MyImage.Source = bitImage;
            }
        }
    }
}

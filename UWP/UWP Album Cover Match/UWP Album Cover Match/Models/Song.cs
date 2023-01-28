using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace UWP_Album_Cover_Match.Models
{
    internal class Song
    {
        internal int SongId;
        internal string SongName;
        internal string SongPerformedBy;
        internal string SongAlbumIn;
        internal StorageFile SongFile;
        internal bool IsSelected;
        internal BitmapImage SongThumbnail;
    }
}

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
using LearnApp.Excercise21.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnApp.Excercise21
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataBindingPage : Page
    {
        internal List<Book> books;

        public DataBindingPage()
        {
            this.InitializeComponent();

            books = Book.GetBooks();
            MyGridView.ItemsSource = books;
            MyListView.ItemsSource = books;
        }

        private void OnItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as Book;
            
            if(item != null)
            {
                InformationTextBlock.Text = $"{item.Title} {item.Author}";
            }
        }
    }
}

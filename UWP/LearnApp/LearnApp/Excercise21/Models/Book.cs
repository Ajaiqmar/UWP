using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Excercise21.Models
{
    internal class Book
    {
        internal int BookId { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal string CoverImage { get; set; }

        internal static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            for(int i=1;i<14;i++)
            books.Add(new Book { BookId = i, Title = "Vulpate", Author = "Confucius", CoverImage = ("../../Assets/"+i+".png")});

            return books;
        }
    }
}

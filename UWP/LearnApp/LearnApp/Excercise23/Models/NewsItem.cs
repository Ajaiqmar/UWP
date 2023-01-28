using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Excercise23.Models
{
    internal enum Category
    {
        FINANCIAL,
        FOOD
    }

    internal class NewsItem
    {
        internal int Id { get; set; }
        internal Category NewsCategory { get; set; }
        internal string HeadLine { get; set; }
        internal string SubHeadLine { get; set; }
        internal string DateLine { get; set; }
        internal string Image { get; set; }

        internal static List<NewsItem> GetNewsItems()
        {
            List<NewsItem> items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, NewsCategory = Category.FINANCIAL, HeadLine = "Lorem Ipsum", SubHeadLine = "doro sit amet", DateLine = "Nunc tristique nec", Image = "../../Assets/Financial1.png" });
            items.Add(new NewsItem() { Id = 2, NewsCategory = Category.FINANCIAL, HeadLine = "Etiam ac felis viverra", SubHeadLine = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "../../Assets/Financial2.png" });
            items.Add(new NewsItem() { Id = 3, NewsCategory = Category.FINANCIAL, HeadLine = "Integer sed turpis erat", SubHeadLine = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "../../Assets/Financial3.png" });
            items.Add(new NewsItem() { Id = 4, NewsCategory = Category.FINANCIAL, HeadLine = "Proin sem neque", SubHeadLine = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "../../Assets/Financial4.png" }); 
            items.Add(new NewsItem() { Id = 5, NewsCategory = Category.FINANCIAL, HeadLine = "Mauris bibendum non leo vitae tempor", SubHeadLine = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "../../Assets/Financial5.png" });
                                               
            items.Add(new NewsItem() { Id = 6, NewsCategory = Category.FOOD, HeadLine = "Lorem ipsum", SubHeadLine = "dolor sit amet", DateLine = "Nunc tristique nec", Image = "../../Assets/Food1.png" });
            items.Add(new NewsItem() { Id = 7, NewsCategory = Category.FOOD, HeadLine = "Etiam ac felis viverra", SubHeadLine = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "../../Assets/Food2.png" });
            items.Add(new NewsItem() { Id = 8, NewsCategory = Category.FOOD, HeadLine = "Integer sed turpis erat", SubHeadLine = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "../../Assets/Food3.png" });
            items.Add(new NewsItem() { Id = 9, NewsCategory = Category.FOOD, HeadLine = "Proin sem neque", SubHeadLine = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "../../Assets/Food4.png" });
            items.Add(new NewsItem() { Id = 10,NewsCategory = Category.FOOD, HeadLine = "Mauris bibendum non leo vitae tempor", SubHeadLine = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "../../Assets/Food5.png" });

            return items;
        }
    }
}

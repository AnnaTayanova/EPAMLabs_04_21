using System;
using System.Text;
using System.Threading.Tasks;

namespace Hierarhy
{
    class Book : Printed_product
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public Book(int pages, int height, int width, string author, string name)
        {
            Pages = pages;
            Height = height;
            Width = width;
            Author = author;
            Name = name;
        }
        public override void GetInfo()
        {
            Console.WriteLine("\nКнига с названием {0} автора {1} размером {2} на {3} имеет {4} страниц(ы)", Name, Author, Height, Width, Pages);
        }
    }
}

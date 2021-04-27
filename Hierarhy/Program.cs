using System;
using System.Text;
using System.Threading.Tasks;

namespace Hierarhy
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook Notebook1 = new Notebook(20,15,15);
            Notebook1.GetInfo();
            
            Diary Diary1 = new Diary(50, 25, 18, "1-5");
            Diary1.GetInfo();

            Book Book1 = new Book(80, 20, 12, "'Стивен Кинг'", "'Зеленая миля'");
            Book1.GetInfo();
            Console.ReadKey();
        }

    }

       abstract class Printed_product
        {
        public int Pages {get; set;}
        public int Height {get; set;}
        public int Width {get; set;}
        
        public abstract void GetInfo();
        }

       class Notebook : Printed_product
       {
           public Notebook(int pages, int height, int width)
           {
               Pages = pages;
               Height = height;
               Width = width;
           }
           public override void GetInfo()
           {
               Console.WriteLine("\nБлокнот размером {0} на {1} имеет {2} страниц(ы)", Height, Width, Pages);
           }
       }
       class Diary : Printed_product
       {
           public string Type { get; set; }
           public Diary(int pages, int height, int width, string type)
           {
               Pages = pages;
               Height = height;
               Width = width;
               Type = type;
           }
           public override void GetInfo()
           {
               Console.WriteLine("\nДневник для {0} класс(ы) размером {1} на {2} имеет {3} страниц(ы)", Type, Height, Width, Pages);
           }
       }
       class Book : Printed_product 
       {
           public string Author {get; set;}
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

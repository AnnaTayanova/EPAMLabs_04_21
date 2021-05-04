using System;
using System.Text;
using System.Threading.Tasks;

namespace Hierarhy
{
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
}

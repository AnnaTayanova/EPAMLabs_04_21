using System;
using System.Text;
using System.Threading.Tasks;

namespace Hierarhy
{
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
}

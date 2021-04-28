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
}

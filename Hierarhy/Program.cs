using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hierarhy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Printed_product> ListPP = new List<Printed_product>();
            {
                Notebook Notebook1 = new Notebook(20, 15, 15);
                Notebook Notebook2 = new Notebook(1, 20, 25);
                Diary Diary1 = new Diary(50, 25, 18, "1-5");
                Diary Diary2 = new Diary(50, 26, 20, "6-11");
                Book Book1 = new Book(80, 20, 12, "'Стивен Кинг'", "'Зеленая миля'");
                Book Book2 = new Book(94, 25, 18, "'Тесс Герритсен'", "'Хирург'");

                ListPP.Add(Notebook1);
                ListPP.Add(Notebook2);
                ListPP.Add(Diary1);
                ListPP.Add(Diary2);
                ListPP.Add(Book1);
                ListPP.Add(Book2);

                Console.WriteLine("Список печатной продукции:");
                foreach (Printed_product elements in ListPP)
                {
                    elements.GetInfo();
                }

                try
                {
                    foreach (Printed_product elements in ListPP)
                    {
                        if (elements.Pages < 10)
                        {
                            throw new Exception("Продукт должен иметь более 10 страниц!");
                        }
                    }
                }
                catch
                {
                    var WrongElementIndex = ListPP.FindIndex(element => element.Pages < 10);
                    ListPP[WrongElementIndex].Pages = 10; 
                }

                Console.WriteLine("\n\n\nОтсортированный список по убыванию количества страниц:");
                var SortedListPP = (
                    from elements in ListPP
                    orderby elements.Pages descending
                    select elements).ToList();

                foreach (Printed_product elements in SortedListPP)
                {
                    elements.GetInfo();
                }

                Console.ReadKey();
            }
        }

    }       
}

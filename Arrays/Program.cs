using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
            static void Main(string[] args)
            {
                //создание и вывод массива
                Console.WriteLine("Массив целых чисел, выбранных рандомно:");
                int[] Array = new int[6];                                  
                Random RandArr = new Random();                             


                for (int i = 0; i < Array.Length; i++)                     
                {
                    Array[i] = RandArr.Next(1, 50);                        
                    Console.Write(Array[i] + " ");                         
                }
            
                //сортировки массива
                Sorting(Array,true);                          
                Console.WriteLine("\n\nОтсортированный массив чисел по убыванию:");

                for (int i = 0; i < Array.Length; i++)                        
                    Console.Write(Array[i] + " ");                         


                Sorting(Array, false);                          
                Console.WriteLine("\n\nОтсортированный массив чисел по возрастанию:");

                for (int i = 0; i < Array.Length; i++)                     
                    Console.Write(Array[i] + " ");                         

                Console.Write("\n\nДля завершения работы нажмите любую клавишу:");
                Console.ReadKey();
            }


            static int[] Sorting(int[] Array, bool isDesk)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - 1; j++)
                    {
                        if (Array[j] < Array[j + 1] && isDesk == true)
                        {
                            int b = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = b;
                        }

                        if (Array[j] > Array[j + 1] && isDesk == false)
                        {
                            int b = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = b;
                        }
                    }
                }
                return Array;
            }
           
        }
    }

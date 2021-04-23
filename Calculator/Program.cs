using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            char again = 'д';
            while (again == 'д')
            {
                //ввод значений

                Console.WriteLine("Введите первое значение:");
                double Value1 = Convert.ToDouble(Console.ReadLine());
              
                Console.WriteLine("Выберите действие: +  -  *  / ");
                char Operation = Convert.ToChar(Console.ReadLine());
      
                Console.WriteLine("Введите второе значение:");
                double Value2 = Convert.ToDouble(Console.ReadLine());

                //выполнение задачи согласно выбранному оператору

                double Result = 0;
                switch (Operation)
                {
                    case '+':
                        Result = Value1 + Value2;
                        Console.WriteLine();
                        Console.WriteLine("{0} {1} {2} = {3}", Value1, Operation, Value2, Result);
                        break;
                    case '-':
                        Result = Value1 - Value2;
                        Console.WriteLine();
                        Console.WriteLine("{0} {1} {2} = {3}", Value1, Operation, Value2, Result);
                        break;
                    case '*':
                        Result = Value1 * Value2;
                        Console.WriteLine();
                        Console.WriteLine("{0} {1} {2} = {3}", Value1, Operation, Value2, Result);
                        break;
                    case '/':
                        if (Value2 != 0)
                        {
                            Result = Value1 / Value2;
                            Console.WriteLine();
                            Console.WriteLine("{0} {1} {2} = {3}", Value1, Operation, Value2, Result);
                        }
                        else Console.WriteLine("Деление на ноль невозможно!");
                        break;
                }
                
                Console.WriteLine("\nПродолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());

            }
        }

    }
}

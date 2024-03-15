/* Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, 
 * а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 
 * 4 – частное). После этого на консоль выводится ответ. Используйте обработку 
 * исключений для защиты от ввода некорректных данных. */

using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace note
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            bool Flag = true;

            while (Flag)
            {
                try
                {
                    Console.Write("Enter an integer number: X = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an integer number: Y = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите код операции:\n0 - завершение программы\n1 - сложение\n2 - вычитание\n3 - произведение\n4 - частное");
                    int c = Convert.ToInt32(Console.ReadLine());

                    if (c < 0 || c > 4)
                    {
                        Console.WriteLine("Нет операции с указанным номером");
                    }

                    switch (c)
                    {
                        case 0:
                            Flag = false;
                            break;
                        case 1:
                            Console.Write("Ответ: ");
                            Console.WriteLine(a + b);
                            break;
                        case 2:
                            Console.Write("Ответ: ");
                            Console.WriteLine(a - b);
                            break;
                        case 3:
                            Console.Write("Ответ: ");
                            Console.WriteLine(a * b);
                            break;
                        case 4:
                            if (b == 0)
                            {
                                Console.WriteLine("Деление на ноль");
                                break;
                            }
                            Console.Write("Ответ: ");
                            Console.WriteLine(Math.Round((double)a / b, 3));
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Неверный формат ввода");
                }
            }
            
            Console.ReadKey();
        }
    }
}
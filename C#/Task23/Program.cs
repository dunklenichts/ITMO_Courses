/* Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить 
 * проверку работы метода. */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1, чтобы выйти");
            try
            {
                while (true)
                {
                    Console.Write("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1) break;
                    FactorialAsync(n);
                    Sum(n);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadLine();
        }

        static void Factorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i < n+1; i++)
            {
                factorial *= i;
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{n}! = {factorial}");
        }

        // доп функция, чтобы увидеть работу асинхронного программирования
        static void Sum(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += 1;
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Сумма чисел до {n} = {sum}");
            Console.WriteLine();
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
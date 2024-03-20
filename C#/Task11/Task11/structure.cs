/* Разработать структуру для решения линейного уравнения 0=kx+b. 
 * Коэффициенты уравнения k, b реализовать с помощью полей вещественного 
 * типа. Для решения уравнения предусмотреть метод Root. Создать экземпляр 
 * разработанной структуры. Осуществить использование экземпляра в программе. */

using System;
using System.IO;
using System.Runtime.InteropServices;
using Task11;

namespace note
{
    class structure
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Func func = new Func(k, b);
            Console.WriteLine(func.Root());

            Console.ReadKey();
        }
    }
}
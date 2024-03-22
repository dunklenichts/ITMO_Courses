/*  Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать. 
    Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. 
    Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, сделав ряд, 
    он спускается вниз. 
    Второй садовник начинает работу с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, 
    он перемещается влево. Если садовник видит, что участок сада уже выполнен другим садовником, он 
    идет дальше. 
    Садовники должны работать параллельно. Создать многопоточное приложение, моделирующее 
    работу садовников. */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        const int n = 10;
        static int[,] garden = new int[n, n];

        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    garden[i, j] = random.Next(1, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            ThreadStart threadStart = new ThreadStart(Gard1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gard2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }


        static void Gard1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = -1;
                        Thread.Sleep(delay);
                    }
                }
            }
        }

        static void Gard2()
        { 
            for (int i = n-1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                }
            }
        }
    }
}
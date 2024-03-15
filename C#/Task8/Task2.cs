/* Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
 * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, 
 * ответ выведите на консоль. */

using System.IO;
using System;
using static System.Net.WebRequestMethods;

namespace Task8
{
    class Task2
    {
        static void Main(string[] args)
        {
            string path = @"D:\\Новая папка\\Numbers.txt";
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }

            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    k += Convert.ToInt32(sr.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сумма чисел: {0}", k);
            Console.ReadKey();
        }
    }
}
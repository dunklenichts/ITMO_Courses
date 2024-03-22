/* Сформировать массив случайных целых чисел (размер  задается пользователем). 
   Вычислить сумму чисел массива и максимальное число в массиве.  Реализовать  
   решение  задачи  с  использованием  механизма  задач продолжения. */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n  = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);
            task1.Start();

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(SumArray);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(MaxNum);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            Func<int[], int, int, object> func4 = new Func<int[], int, int, object>((array, max, sum) =>
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine($"\nМаксимальное число: {max}, сумма чисел: {sum}");
                return null;
            });

            Task.Run(() => func4(task1.Result, task3.Result, task2.Result)).Wait();
        }

        static int[] GetArray(object a)
        {
            int n = (int)a;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
            }

            return array;
        }

        static int SumArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;

            foreach (int i in array)
            {
                sum += i;
            }

            return sum;
        }

        static int MaxNum(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[0];

            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }

        static void PrintNums(Task<int[]> task, int max, int sum)
        {
            int[] array = task.Result;

            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine($"MAX = {max}, sum = {sum}");
        }
    }
}
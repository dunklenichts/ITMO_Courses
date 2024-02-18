/* Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: 
 * N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение 
 * суммы (в результате будут выведены квадраты всех целых чисел от 1 до N) */

using System.Buffers;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write N > 0: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int Sum = 0;

        if (n < 0)
        {
            Console.WriteLine("Write a correct number");
            Environment.Exit(0);
        }

        for (int i=0; i<(2 * n - 1); i += 2)
        {
            Sum += i;
        }

        Console.WriteLine(Sum);
    }
}

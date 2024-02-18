/* Осуществить ввод последовательности целых чисел и сравнить, что больше, количество 
 * положительных или количество отрицательных. Последовательность потенциально не 
 * ограничена, окончанием последовательности служит число 0. */

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        int negativeSum = 0;
        int positiveSum = 0;

        do
        {
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                negativeSum += 1;
            }
            if (n > 0)
            {
                positiveSum += 1;
            }
        } while (n != 0);

        int x = negativeSum > positiveSum ? negativeSum : positiveSum;

        if (negativeSum == positiveSum)
        {
            Console.WriteLine("The amount of numbers is equal");
            Environment.Exit(0);
        }
        if (x == negativeSum)
        {
            Console.WriteLine("negative {0}", x);
        }
        else
        {
            Console.WriteLine("positive {0}", x);
        }
    }
}
/* Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. 
 * Определить количество нечетных положительных элементов, стоящих на четных местах. */

class Task4
{
    static void Main(string[] args)
    {
        int[] array = new int[20];
        Random random = new Random();
        int k = 0;

        for (int i = 0; i < 20; i++)
        {
            array[i] = random.Next(-50, 51);
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                if ((array[i] > 0) & (array[i] % 2 == 0))
                {
                    k++;
                    Console.Write("{0} ", array[i]);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("{0}", k);
    }
}
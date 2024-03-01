/* Сформировать одномерный массив из 15 элементов, которые выбираются с
 * случайным образом из диапазона [0; 50]. Определить сумму максимального 
 * и минимального элементов массива. */

class Task2
{
    static void Main(string[] args)
    {
        int[] array = new int[15];
        Random random = new Random();

        for (int i = 0; i < 15; i++)
        {
            array[i] = random.Next(0, 51);
            Console.Write("{0} ", array[i]);
        }

        int max = array[0];
        int min = array[0];

        foreach (int a in array)
        {
            if (a > max)
            {
                max = a;
            }
            if (a < min)
            {
                min = a;
            }
        }

        Console.WriteLine();
        Console.Write("{0} + {1} = {2}", min, max, max + min);
    }
}
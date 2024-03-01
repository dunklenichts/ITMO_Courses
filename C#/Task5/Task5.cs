/* Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN:
 * 1 0 1 0 1

   0 1 0 1 0

   1 0 1 0 1

   0 1 0 1 0

   1 0 1 0 1 */

class Task5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = (((j % 2 != 0) & (i % 2 != 0)) || ((j % 2 == 0) & (i % 2 == 0))) ? 1 : 0;
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
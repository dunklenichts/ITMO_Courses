/* Сформировать одномерный массив из 7 элементов. Заполнить массив числами, 
 * вводимыми с клавиатуры, определить среднее арифметическое элементов. */

class Task1
{
    static void Main(string[] args)
    {
        int[] array = new int[7];
        int sum = 0;
        int count = 0;

        Console.WriteLine("Enter a number:");
        for (int i = 0; i < 7; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            sum += array[i];
            count++;
        }
        Console.WriteLine("{0}", Math.Round((double)sum / count, 3));
    }
}
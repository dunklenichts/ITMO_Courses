/* Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально 
 * возможное количество квадратов со стороной C (без наложений). Найти количество квадратов, 
 * размещенных на прямоугольнике. Операции умножения и деления не использовать. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter C: ");
        int C = Convert.ToInt32(Console.ReadLine());
        int cnt = 0;
        int temp_B;

        while ((A - C) >= 0)
        {
            temp_B = B;
            while ((temp_B - C) >= 0)
            {
                cnt++;
                temp_B -= C;
            }
            A -= C;
        }
        Console.WriteLine("Amount os sqaures: {0}", cnt);
    }
}

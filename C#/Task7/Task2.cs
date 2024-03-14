/* Создать метод для вычисления объема и площади поверхности куба по длине его ребра. */

namespace Task7
{
    class Task2
    {
        static void GetSquareVolume(int a, out double S, out double V)
        {
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине сторону куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double S;
            double V;

            GetSquareVolume(a, out S, out V);
            Console.WriteLine("Площадь поверхности: {0}", S);
            Console.WriteLine("Объем куба: {0}", V);
            Console.ReadKey();
        }
    }
}
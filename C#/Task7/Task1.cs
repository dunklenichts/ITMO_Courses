/* Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
 * (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения 
 * задачи можно использовать формулу Герона */

namespace Task7
{
    class Task1
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return  Math.Sqrt(p * (p - a)*(p - b)*(p - c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a1:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b1:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c1:");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a2:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b2:");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c2:");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double s1 = GetSquare(a1, b1, c1);
            double s2 = GetSquare(a2, b2, c2);

            if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }

            Console.ReadKey();
        }
    }
}
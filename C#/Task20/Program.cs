/* В приложении объявить тип делегата, который ссылается на метод. 
   Требования к сигнатуре метода следующие:
      - метод получает входным параметром переменную типа double;
      - метод возвращает значение типа double, которое является результатом вычисления.

   Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
      - длину окружности по формуле D = 2 * π* R;
      - площадь круга по формуле S = π* R²;
      - объем шара. Формула V = 4/3 * π * R³. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        delegate double MyDelegate(double r);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = CircleLenght;
            double r = myDelegate(4);
            Console.WriteLine($"Длина окружности при r = 4: {r}");

            myDelegate = CircleSquare;
            r = myDelegate(4);
            Console.WriteLine($"Площадь круга при r = 4:    {r}");

            myDelegate = CircleVolume;
            r = myDelegate(4);
            Console.WriteLine($"Объем шара при r = 4:       {r}");

            Console.ReadKey();
        }

        static double CircleLenght(double r) => Math.Round(2 * Math.PI * r, 3);
        static double CircleSquare(double r) => Math.Round(Math.PI * Math.Pow(r, 2), 3);
        static double CircleVolume(double r) => Math.Round((double)4 / 3 * Math.PI * Math.Pow(r, 3), 3);
    }
}
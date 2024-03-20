/* Разработать статический класс для работы с окружностью. Класс должен 
 * содержать 3 метода:
 *       метод, определяющий длину окружности по заданному радиусу;
 *       метод, определяющий площадь круга по заданному радиусу;
 *       метод, проверяющий принадлежность точки с координатами (x,y) кругу с 
 *              радиусом r и координатами центра x0, y0 */

using System;
using System.IO;
using System.Runtime.InteropServices;
using Task12;

namespace note
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Площадь круга = {0}", Circle.GetSquare(r));
            Console.WriteLine("Длина окружности = {0}", Circle.GetLength(r));
            Console.WriteLine("Принадлежит ли точка с координатами ({0}, {1}) кругу радиусом {2}: {3}", x, y, r, Circle.IsinCircle(x, y, r));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    static class Circle
    {
        // метод, определяющий длину окружности по заданному радиусу
        static public double GetLength(double r)
        {
            return Math.Round(2 * Math.PI * r, 3);
        }

        // метод, определяющий площадь круга по заданному радиусу;
        static public double GetSquare(double r)
        {
            return Math.Round(Math.PI * r * r, 3);
        }

        // метод, проверяющий принадлежность точки с координатами (x,y)
        // кругу с радиусом r и координатами центра x0, y0
        static public string IsinCircle(int x, int y, double r)
        {
            double c = Math.Sqrt(x * x + y * y);

            if (c <= r * r) 
            {
                return "да";
            }
            else
            {
                return "нет";
            }
        }
    }
}

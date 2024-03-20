using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    struct Func
    {
        double k;
        double b;

        public Func(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            double x = -(double)b / k;

            if (k < 0)
            {
                Console.Write("Функция убывает");
            }
            else if (k > 0)
            {
                Console.Write("Функция возрастает");
            }
            else
            {
                return "Функция параллельна Ох";
            }

            Console.WriteLine();

            return $"x = {Math.Round(x, 3)}";
        }
    }
}

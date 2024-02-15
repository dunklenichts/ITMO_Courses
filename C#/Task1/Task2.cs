/* Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). 
 * Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника. */

using System.Diagnostics.CodeAnalysis;

Console.Write("Enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int p = 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
int s = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

Console.WriteLine("p = {0}, s = {1}", p, s);
Console.ReadKey();

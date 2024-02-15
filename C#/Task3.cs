/* Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). 
 * Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости. 
 * Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона */

using System.Diagnostics.CodeAnalysis;

Console.Write("Enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double firstSide = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
double secondSide = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
double thirdSide = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

double p = (double)(firstSide + secondSide + thirdSide) / 2;
double s = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));

Console.WriteLine("s = {0}", s);
Console.ReadKey();
﻿/* Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью */

using System.Diagnostics.CodeAnalysis;

Console.Write("Enter l: ");
double l = Convert.ToDouble(Console.ReadLine());
double r = (double)l / (2 * Math.PI);
double s = Math.PI * Math.Pow(r, 2);
Console.WriteLine("r = {0}, l = {1}", Math.Round(r, 3), Math.Round(s, 3));
Console.ReadKey();
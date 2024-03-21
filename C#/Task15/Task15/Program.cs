/* Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
       - метод void SetStart(int x) - устанавливает начальное значение
       - метод int GetNext() - возвращает следующее число ряда
       - метод void Reset() - выполняет сброс к начальному значению
   
   Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
   В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической 
   прогрессии соответственно.*/

using System;
using System.IO;
using System.Runtime.InteropServices;
using Task15;

namespace note
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Какую прогрессию использовать: \n1 - арифметическую,\n2 - геометрическую: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Повтор прогрессии: ");
                int limitNumber = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    ArithProgression arithProgression = new ArithProgression();
                    arithProgression.setStart(10);
                    arithProgression.setStep(3);

                    for (int i = 0; i < limitNumber; i++)
                    {
                        Console.WriteLine(arithProgression.getNext());
                    }

                    arithProgression.Reset();
                }
                if (choice == 2)
                {
                    GeomProgression geomProgression = new GeomProgression();
                    geomProgression.setStart(10);
                    geomProgression.setStep(3);

                    for (int i = 0; i < limitNumber; i++)
                    {
                        Console.WriteLine(geomProgression.getNext());
                    }

                    geomProgression.Reset();
                }
                if (choice != 1 || choice != 2)
                {
                    Console.WriteLine("Выберите 1 или 2");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
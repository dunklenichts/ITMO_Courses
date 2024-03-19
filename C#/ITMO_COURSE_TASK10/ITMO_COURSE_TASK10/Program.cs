/* Угол задан с помощью целочисленных значений gradus - градусов, 
 * min - угловых минут, sec - угловых секунд. Реализовать класс, 
 * в котором указанные значения представлены в виде свойств. Для 
 * свойств предусмотреть проверку корректности данных. Класс должен 
 * содержать конструктор для установки начальных значений, а также 
 * метод ToRadians для перевода угла в радианы. Создать объект на 
 * основе разработанного класса. Осуществить использование объекта в программе. */

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ITMO_COURSE_TASK10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int inputDegree = Convert.ToInt32(Console.ReadLine());
                int inputMinutes = Convert.ToInt32(Console.ReadLine());
                int inputSeconds = Convert.ToInt32(Console.ReadLine());

                Angle angle = new Angle(inputDegree, inputMinutes, inputSeconds);

                Console.WriteLine(Math.Round(angle.ToRadians(), 3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
/* Задан класс Building, который описывает здание. 
 * Класс содержит следующие элементы:
       - адрес здания;
       - длина здания;
       - ширина здания;
       - высота здания.

 * В классе Building нужно реализовать следующие методы:
       - конструктор с 4 параметрами;
       - свойства get/set для доступа к полям класса;
       - метод Print(), который выводит информацию о здании.

 * Разработать класс MultiBuilding, который наследует возможности 
 * класса Building и добавляет поле этажность. В классе MultiBuilding 
 * реализовать следующие элементы:
       - конструктор с 5 параметрами – реализует вызов конструктора базового класса;
       - свойство get/set доступа к внутреннему полю класса;
       - метод Print(), который обращается к методу Print() базового класса Building 
                        для вывода информации о всех полях класса.

 * Класс MultiBuilding сделать таким, что не может быть унаследован */

using System;
using System.IO;
using System.Runtime.InteropServices;
using Task13;

namespace note
{
    class structure
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите адрес: ");
                string add = Console.ReadLine();
                Console.Write("Введите длину: ");
                double len = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ширину: ");
                double wei = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту: ");
                double hei = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите этаж: ");
                int lvl = Convert.ToInt32(Console.ReadLine());

                Building building = new Building(add, len, wei, hei);
                MultiBuilding multiBuilding = new MultiBuilding(add, len, wei, hei, lvl);

                Console.WriteLine(building.Print());
                Console.WriteLine(); 
                Console.WriteLine(multiBuilding.Print());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
/* Разработать класс MultiBuilding, который наследует возможности 
 * класса Building и добавляет поле этажность. В классе MultiBuilding 
 * реализовать следующие элементы:
        -конструктор с 5 параметрами – реализует вызов конструктора базового класса;
        -свойство get / set доступа к внутреннему полю класса;
        -метод Print(), который обращается к методу Print() базового класса Building 
                        для вывода информации о всех полях класса.

 * Класс MultiBuilding сделать таким, что не может быть унаследован */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task13
{
    class MultiBuilding:Building
    {
        int buildingLevel;

        public MultiBuilding(string buildingAddress, double buildingLength, double buildingWeight, double buildingHeight, int buildingLevel)
            :base(buildingAddress, buildingLength, buildingWeight, buildingHeight)
        { 
            this.BuildingLevel = buildingLevel;
        }

        public int BuildingLevel
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите число, большее 0");
                }
                else
                {
                    buildingLevel = value;
                }
            }
            get { return buildingLevel; }
        }

        public string Print()
        {
            string result = base.Print();
            result += $"\nLevel: {buildingLevel}";

            return result;
        }
    }
}

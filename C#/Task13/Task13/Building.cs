using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    /* Задан класс Building, который описывает здание. 
     * Класс содержит следующие элементы:
           - адрес здания;
           - длина здания;
           - ширина здания;
           - высота здания. */
    class Building
    {
        string buildingAddress;
        double buildingLength;
        double buildingWeight;
        double buildingHeight;

        // конструктор с 4 параметрами
        public Building(string buildingAddress, double buildingLength, double buildingWeight, double buildingHeight)
        {
            this.BuildingAddress = buildingAddress;
            this.BuildingLength = buildingLength;
            this.BuildingWeight = buildingWeight;
            this.BuildingHeight = buildingHeight;
        }

        public string BuildingAddress
        {
            get { return buildingAddress; }
            set { buildingAddress = value; }
        }

        public double BuildingLength
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите число, большее 0");
                }
                else
                {
                    buildingLength = value;
                }
            }
            get { return buildingLength; }
        }


        public double BuildingWeight
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите число, большее 0");
                }
                else
                {
                    buildingWeight = value;
                }
            }
            get { return buildingWeight; }
        }

        public double BuildingHeight
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите число, большее 0");
                }
                else
                {
                    buildingHeight = value;
                }
            }
            get { return buildingHeight; }
        }

        // метод Print(), который выводит информацию о здании
        public string Print()
        {
            return $"Address: {buildingAddress},\nlength: {buildingLength},\nweight: {buildingWeight}\nheight: {buildingHeight}";
        }
    }
}

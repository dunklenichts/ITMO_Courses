/* Необходимо разработать программу для получения информации о товаре из json-файла.
   Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара. */

using System.IO;
using System.Text.Json;
using _16extra;
using System;

namespace note
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;

            using (StreamReader sr = new StreamReader("../../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            Item[] items = JsonSerializer.Deserialize<Item[]>(jsonString);

            Item maxItem = items[0];
            foreach(Item i in items)
            {
                if (i.Cost > maxItem.Cost)
                {
                    maxItem.Cost = i.Cost;
                    maxItem.Name = i.Name;
                    maxItem.Code = i.Code;
                }
            }

            Console.WriteLine($"Код: {maxItem.Code},\nНазвание: {maxItem.Name}\nЦена: {maxItem.Cost}");
        }
    }
}
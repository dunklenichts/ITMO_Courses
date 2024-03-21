/* Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.
   Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» 
   (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
   Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
   Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json». */

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Task16;

namespace note
{
    class Program1
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Item[] items = new Item[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите код товара: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара: ");
                double cost = Convert.ToDouble(Console.ReadLine());

                items[i] = new Item() { Code = code, Name = name, Cost = cost };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(items, options);

            using (StreamWriter sw = new StreamWriter("../../../../Products.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
/* Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, 
 * которая выводит статистику по файлу - количество символов, строк и слов в тексте. */

using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Task8
{
    class Task3
    {
        static void Main(string[] args)
        {
            string path = @"D:\Новая папка\fish.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                String line;
                int i = 0;
                string[] textMass;
                int lenString = 0;
                int characterCount = 0;


                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                    Console.WriteLine(line);
                    textMass = line.Split(' ');
                    lenString += textMass.Length;

                    foreach (char symbol in line)
                    {
                        characterCount++;
                    }
                }

                Console.WriteLine("Количество строк: {0}", i.ToString());
                Console.WriteLine("Количество слов: {0}", lenString);
                Console.WriteLine("Количество символов: {0}", characterCount);
            }
        }
    }
}
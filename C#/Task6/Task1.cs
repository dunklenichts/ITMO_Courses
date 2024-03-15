/* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
 * Знаки препинания не используются. Найти самое длинное слово в строке. */

using System;

class Task1
{
    static void Main(string[] args)
    {
        string[] arrayString = Console.ReadLine().Split();
        string minString = arrayString[0];

        foreach (string str in arrayString)
        {
            if (str.Length < minString.Length)
            {
                minString = str;
            }
        }
        Console.WriteLine(minString);
    }
}
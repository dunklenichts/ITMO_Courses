/* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
 * Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом 
 * без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»). */

using System;

class Task2
{
    static void Main(string[] args)
    {
        string enterString = Console.ReadLine();
        string[] arrayString = enterString.Split();
        string resultString = "";
        string str2 = "";

        foreach (string str in arrayString)
        {
            resultString += str.Substring(0, 1).ToLower() + str.Substring(1);
        }

        foreach (char c in resultString)
        {
            str2 = c + str2;
        }

        if (resultString.Equals(str2))
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("non palindrome");
        }
    }
}
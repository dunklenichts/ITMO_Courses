/* Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
 * В строке может быть несколько фрагментов, заключённых в фигурные скобки. Возможно 
 * использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала. */

using System;
using System.Runtime.InteropServices;

class Task3
{
    static void Main(string[] args)
    {
        string eneterString = "Delete the text {enclosed} in {curly} brackets";
        string[] arrayString = eneterString.Split();
        int firstIndex = 0;
        int secondIndex = 0;

        foreach (string str in arrayString)
        {
            foreach (char c in str)
            {
                //Console.WriteLine(c);
                
                    if (str.Contains('{') & str.Contains('}'))
                    {
                        if (c == '}')
                        {
                            secondIndex = str.IndexOf(c);
                        }
                        if (c == '{')
                        {
                            firstIndex = str.IndexOf(c);
                        }
                    }
                    //if (str.Contains('{') & str.Contains('}'))/
                    //Console.WriteLine(str);
                    Console.WriteLine(firstIndex);
                
            }
            //Console.WriteLine(firstIndex);
            //Console.WriteLine(secondIndex);
        }
       // Console.WriteLine(arrayString);
        
    }
}
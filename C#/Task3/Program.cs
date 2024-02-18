/* Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста, 
 * обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 
 * 41 — «сорок один год». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке */
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write an age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        int firstNumber = age / 10;
        int secondNumber = age % 10;
        string ageString = "";
        string outputSecond = "";

        if (age < 20 || age > 69)
        {
            Console.Write("Wrong age");
            Environment.Exit(0);
        }
        #region formAge
        if (secondNumber == 0 || secondNumber > 4 & secondNumber <= 9)
        {
            ageString = "лет";
        }
        if (secondNumber == 1)
        {
            ageString = "год";
        }
        if (secondNumber == 2 || secondNumber == 3 || secondNumber == 4)
        {
            ageString = "года";
        }
        #endregion

        #region secondNumberAge
        if (secondNumber == 1)
        {
            outputSecond = "один";
        }
        if (secondNumber == 2)
        {
            outputSecond = "два";
        }
        if (secondNumber == 3)
        {
            outputSecond = "три";
        }
        if (secondNumber == 4)
        {
            outputSecond = "четыре";
        }
        if (secondNumber == 5)
        {
            outputSecond = "пять";
        }
        if (secondNumber == 6)
        {
            outputSecond = "шесть";
        }
        if (secondNumber == 7)
        {
            outputSecond = "семь";
        }
        if (secondNumber == 8)
        {
            outputSecond = "восемь";
        }
        if (secondNumber == 9)
        {
            outputSecond = "девять";
        }
        #endregion

        #region firstNumberAge
        switch (firstNumber)
        {
            case 2:
                Console.WriteLine("Двадцать", outputSecond, ageString);
                break;
            case 3:
                Console.WriteLine("Тридцать {0} {1}", outputSecond, ageString);
                break;
            case 4:
                Console.WriteLine("Сорок {0} {1}", outputSecond, ageString);
                break;
            case 5:
                Console.WriteLine("Пятьдесят {0} {1}", outputSecond, ageString);
                break;
            case 6:
                Console.WriteLine("Шестьдесят {0} {1}", outputSecond, ageString);
                break;
        }
        #endregion
    }
}
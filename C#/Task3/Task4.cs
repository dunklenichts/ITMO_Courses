/* Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 
 * 814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение 
 * об ошибке */


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int firstNumber = number / 10;
        int secondNumber = number % 10;
        string textAgeFirst = "";
        string textAgeSecond = "";
        string textAgeThird = "";
        int Flag = 0;


        if (number > 999 || number < 69)
        {
            Console.Write("Wrong number");
            Environment.Exit(0);
        }
        else
        {
            #region firstNumberAge
            switch (number / 100)
            {
                case 1:
                    textAgeFirst = "Сто";
                    break;
                case 2:
                    textAgeFirst = "Двести";
                    break;
                case 3:
                    textAgeFirst = "Триста";
                    break;
                case 4:
                    textAgeFirst = "Четыреста";
                    break;
                case 5:
                    textAgeFirst = "Пятьсот";
                    break;
                case 6:
                    textAgeFirst = "Шестьсот";
                    break;
                case 7:
                    textAgeFirst = "Семьсот";
                    break;
                case 8:
                    textAgeFirst = "Восемьсот";
                    break;
                case 9:
                    textAgeFirst = "Девятьсот";
                    break;
            }
            #endregion

            #region secondNumberAge
            switch (number / 10 % 10)
            {
                case 1:
                    Flag = 1;
                    break;
                case 2:
                    textAgeSecond = "двадцать";
                    break;
                case 3:
                    textAgeSecond = "тридцать";
                    break;
                case 4:
                    textAgeSecond = "сорок";
                    break;
                case 5:
                    textAgeSecond = "пятьдесят";
                    break;
                case 6:
                    textAgeSecond = "шестьдесят";
                    break;
                case 7:
                    textAgeSecond = "семьдесят";
                    break;
                case 8:
                    textAgeSecond = "восемьдесят";
                    break;
                case 9:
                    textAgeSecond = "девяносто";
                    break;
            }

            if (Flag == 1)
            {
                switch (number % 100)
                {
                    case 11:
                        textAgeSecond = "одиннадцать";
                        break;
                    case 12:
                        textAgeSecond = "двенадцать";
                        break;
                    case 13:
                        textAgeSecond = "тринадцать";
                        break;
                    case 14:
                        textAgeSecond = "четырнадцать";
                        break;
                    case 15:
                        textAgeSecond = "пятнадцать";
                        break;
                    case 16:
                        textAgeSecond = "шестнадцать";
                        break;
                    case 17:
                        textAgeSecond = "семнадцать";
                        break;
                    case 18:
                        textAgeSecond = "восемнадцать";
                        break;
                    case 19:
                        textAgeSecond = "девятнадцать";
                        break;
                }

                Console.Write(string.Format("{0} {1}", textAgeFirst, textAgeSecond));
            }
            #endregion
            else
            {
                #region thirdNumberAge
                switch (number % 10)
                {
                    case 1:
                        textAgeThird = "один";
                        break;
                    case 2:
                        textAgeThird = "два";
                        break;
                    case 3:
                        textAgeThird = "три";
                        break;
                    case 4:
                        textAgeThird = "четыре";
                        break;
                    case 5:
                        textAgeThird = "пять";
                        break;
                    case 6:
                        textAgeThird = "шесть";
                        break;
                    case 7:
                        textAgeThird = "семь";
                        break;
                    case 8:
                        textAgeThird = "восемь";
                        break;
                    case 9:
                        textAgeThird = "девять";
                        break;
                }
                #endregion
                Console.Write(string.Format("{0} {1} {2}", textAgeFirst, textAgeSecond, textAgeThird));
            }
        }
    }
}

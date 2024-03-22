/* Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, 
 * баланса, ФИО владельца. 
   Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера 
   счета. Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько 
   экземпляров класса, параметризированного различными типам. Заполнить его поля и вывести на экран 
   информацию об экземпляре класса. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program2
    {
        static void Main(string[] args)
        {
            Bank<int> bank1 = new Bank<int>();
            bank1.Input();
            Console.WriteLine(bank1.GetInfo());

            Console.WriteLine();

            Bank<string> bank2 = new Bank<string>();
            bank2.Input();
            Console.WriteLine(bank2.GetInfo());
        }
    }
}

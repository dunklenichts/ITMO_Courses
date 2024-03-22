


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Bank <T>
    {
        public T AccountNumber { get; set; }
        public double Balance { get; set; }
        public string FullName { get; set; }

        public string GetInfo()
        {
            return $"Номер счета: {AccountNumber}\nБаланс: {Balance}\nИмя: {FullName}";
        }

        public void Input()
        {
            try
            {
                Console.Write("Введите номер счета: ");
                AccountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

                Console.Write("Введите баланс: ");
                Balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ФИО: ");
                FullName = Console.ReadLine();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

/* Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора, 
   частотой  работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти 
   видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. 
   Создать список, содержащий 6-10 записей с различным набором значений характеристик.

   Определить:
        - все компьютеры с указанным процессором. Название процессора запросить у пользователя;
        - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
        - вывести весь список, отсортированный по увеличению стоимости;
        - вывести весь список, сгруппированный по типу процессора;
        - найти самый дорогой и самый бюджетный компьютер;
        - есть ли хотя бы один компьютер в количестве не менее 30 штук? */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task19;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=0, Name="Name", Processor=1, Frequency=3.5, RAM=32,
                                Videocard=8, HardDisk=512, Cost=1200.312, Amount=1},
                new Computer(){Code=1, Name="Name1", Processor=3, Frequency=2, RAM=32,
                                Videocard=16, HardDisk=512, Cost=3464.345, Amount=4},
                new Computer(){Code=2, Name="Name2", Processor=2, Frequency=2.5, RAM=64,
                                Videocard=16, HardDisk=512, Cost=43534.312, Amount=1},
                new Computer(){Code=3, Name="Name3", Processor=3, Frequency=2.5, RAM=32,
                                Videocard=32, HardDisk=512, Cost=145.312, Amount=3},
                new Computer(){Code=4, Name="Name4", Processor=1, Frequency=2, RAM=64,
                                Videocard=16, HardDisk=512, Cost=3145.6865, Amount=6},
                new Computer(){Code=5, Name="Name5", Processor=1, Frequency=3.5, RAM=32,
                                Videocard=8, HardDisk=512, Cost=624, Amount=23}
            };

            try
            {
                while (true)
                {
                    Console.WriteLine("Какую информацию вывести:\n" +
                    "1 - все компьютеры с указанным процессором\n" +
                    "2 - все компьютеры с объемом ОЗУ не ниже, чем указано\n" +
                    "3 - вывести весь список, отсортированный по увеличению стоимости\n" +
                    "4 - вывести весь список, сгруппированный по типу процессора\n" +
                    "5 - найти самый дорогой и самый бюджетный компьютер\n" +
                    "6 - есть ли хотя бы один компьютер в количестве не менее 30 штук?\n" +
                    "0 - выход");

                    int temp = Convert.ToInt32(Console.ReadLine());
                    if (temp == 1)
                    {
                        // все компьютеры с указанным процессором
                        Console.Write("Введите тип процессора (1, 2, 3): ");
                        int typeProcessor = Convert.ToInt32(Console.ReadLine());
                        List<Computer> comp1 = computers.Where(x => x.Processor == typeProcessor).ToList();
                        Print(comp1);
                    }
                    if (temp == 2)
                    {
                        // все компьютеры с объемом ОЗУ не ниже, чем указано
                        Console.Write("Введите объем ОЗУ (RAM): ");
                        int volRAM = Convert.ToInt32(Console.ReadLine());
                        List<Computer> comp2 = computers.Where(x => x.RAM >= volRAM).ToList();
                        Print(comp2);
                    }
                    if (temp == 3)
                    {
                        // вывести весь список, отсортированный по увеличению стоимости
                        List<Computer> comp3 = computers.OrderBy(x => x.Cost).ToList();
                        Print(comp3);
                    }
                    if (temp == 4)
                    {
                        // вывести весь список, сгруппированный по типу процессора
                        IEnumerable<IGrouping<int, Computer>> comp4 = computers.GroupBy(x => x.Processor);
                        foreach (IGrouping<int, Computer> gr in comp4)
                        {
                            Console.WriteLine(gr.Key);
                            foreach (Computer comp in gr)
                            {
                                Console.WriteLine($"Код: {comp.Code}\nНазвание: {comp.Name}\nТип процессора: {comp.Processor}\n" +
                                $"Частота процессора: {comp.Frequency}\nRAM: {comp.RAM}\nОбъем видеокарты: {comp.Videocard}\n" +
                                $"Объем жесткого диска: {comp.HardDisk}\nЦена: {comp.Cost}\nКол-во: {comp.Amount}");
                                Console.WriteLine();
                            }
                        }
                    }
                    if (temp == 5)
                    {
                        // найти самый дорогой и самый бюджетный компьютер
                        Computer comp5 = computers.OrderByDescending(x => x.Cost).FirstOrDefault();
                        Console.WriteLine($"Код: {comp5.Code}\nНазвание: {comp5.Name}\nТип процессора: {comp5.Processor}\n" +
                                $"Частота процессора: {comp5.Frequency}\nRAM: {comp5.RAM}\nОбъем видеокарты: {comp5.Videocard}\n" +
                                $"Объем жесткого диска: {comp5.HardDisk}\nЦена: {comp5.Cost}\nКол-во: {comp5.Amount}");
                        Console.WriteLine();
                        Computer comp51 = computers.OrderByDescending(x => x.Cost).LastOrDefault();
                        Console.WriteLine($"Код: {comp51.Code}\nНазвание: {comp51.Name}\nТип процессора: {comp51.Processor}\n" +
                                $"Частота процессора: {comp51.Frequency}\nRAM: {comp51.RAM}\nОбъем видеокарты: {comp51.Videocard}\n" +
                                $"Объем жесткого диска: {comp51.HardDisk}\nЦена: {comp51.Cost}\nКол-во: {comp51.Amount}");
                    }
                    if (temp == 6)
                    {
                        // есть ли хотя бы один компьютер в количестве не менее 30 штук?
                        Console.WriteLine(computers.Any(x => x.Amount >= 30));
                    }
                    if (temp == 0)
                    {
                        break;
                    }
                    if (temp != 1 && temp != 2 && temp != 3 && temp != 4 && temp != 5 && temp != 6 && temp != 0)
                    {
                        Console.WriteLine("Введите число от 0 до 6");
                    }
                }

                Console.ReadKey();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer comp in computers)
            {
                Console.WriteLine($"Код: {comp.Code}\nНазвание: {comp.Name}\nТип процессора: {comp.Processor}\n" +
                    $"Частота процессора: {comp.Frequency}\nRAM: {comp.RAM}\nОбъем видеокарты: {comp.Videocard}\n" +
                    $"Объем жесткого диска: {comp.HardDisk}\nЦена: {comp.Cost}\nКол-во: {comp.Amount}");
                Console.WriteLine();
            }
        }
    }
}
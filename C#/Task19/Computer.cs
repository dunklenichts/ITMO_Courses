/* Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора, 
   частотой  работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти 
   видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Computer
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Processor {  get; set; }
        public double Frequency { get; set; }
        public int RAM { get; set; }
        public int HardDisk { get; set; }
        public int Videocard { get; set; }
        public double Cost { get; set; }
        public int Amount { get; set; }
    }
}

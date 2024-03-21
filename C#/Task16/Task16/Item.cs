/* Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» 
   (целое число), «Название товара» (строка), «Цена товара» (вещественное число).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}

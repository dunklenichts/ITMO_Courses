using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_COURSE_TASK10
{
    public class Angle
    {
        int degrees;
        int minutes;
        int seconds;

        public int Degrees
        {
            set
            {
                if (value > 0 && value < 360)
                {
                    degrees = value;
                }
                else
                {
                    Console.WriteLine("Введите целое число в диапазоне от 0 до 360");
                }
            }
            get
            {
                return degrees;
            }
        }

        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("Введите целое число в диапазоне от 0 до 59");
                }
            }
            get 
            { 
                return minutes; 
            }
        }

        public int Seconds
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("Введите целое число в диапазоне от 0 до 59");
                }
            }
            get 
            { 
                return seconds; 
            }
        }

        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public double ToRadians()
        {
            double totalSeconds = degrees * 3600 + minutes * 60 + seconds;
            
            return (totalSeconds * Math.PI) / (180 * 3600);
        }
    }
}

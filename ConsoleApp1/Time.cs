using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Time
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
        public string Planet;

        public Time (int hour, int min, int sec, string planet)
        {
            Hour = hour;
            Min = min;
            Sec = sec;
            Planet = planet;
        }

        enum Half {
            PM,
            AM
        }

        public override string ToString()
        {
            return $"На планете {Planet} в сутках {Hour} часов, в часе {Min} минут, в минуте {Sec} секунд ";
        }

        public static bool operator < (Time t1, Time t2)
        {
            if (t1.Hour < t2.Hour
                & t1.Min < t2.Min
                & t1.Sec < t2.Sec)
            { return true; }

            else return false;

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("Паша");
            Console.WriteLine(house1.Name);
            house1.Run();

            Time time = new Time(24, 60, 60, "Земля");
            Console.WriteLine(time.ToString());

            Console.WriteLine(Char.MaxValue);
            string str = "24";
            int str1 = Convert.ToInt32(str);

            Console.WriteLine(str1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class House : Mammal, IRun
    {
        public House (string name) 
            : base(name)
        {

        }

        public void Run()
        {
            Console.WriteLine(Name.Length);
        }
    }
}

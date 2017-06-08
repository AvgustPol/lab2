using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiuk
{
    class Son : Base
    {
        public int Number { get; set; }
        public string Name { get; set; }

        int number;
        string name;

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        public Son()
        {
            number = 42;
            name = "Son";
        }

        public void WriteMyName()
        { 
            System.Console.WriteLine(name);
        }

    }
}

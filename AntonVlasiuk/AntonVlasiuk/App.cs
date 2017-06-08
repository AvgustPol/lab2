using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiuk
{
    class App
    {
        static void Main(string[] args)
        {
            Son newSon = new Son();
            newSon.WriteMyName();
            

            Car bmw = new Car();
            bmw.MoveYourBody();

            Vehicle v = new Vehicle();
            v.MoveYourBody();




            System.Console.Read();
        }
    }
}

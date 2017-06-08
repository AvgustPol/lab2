using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiuk
{
    class Base : Movable
    {
        public int id;

        public virtual void MoveYourBody()
        {
            System.Console.WriteLine("Just virtual method");
        }
    }
}

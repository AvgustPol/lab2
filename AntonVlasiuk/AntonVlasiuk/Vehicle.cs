using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiuk
{
    class Vehicle : Base 
    {
        protected String whatIAmDoing;
        protected String whoIAm;

        public Vehicle()
        {
            whatIAmDoing = "I am moving";
            whoIAm = "I`m just a vehicle";
        }

        public override void MoveYourBody()
        {
            System.Console.WriteLine(whoIAm + " and " + whatIAmDoing);
        }

    }
}

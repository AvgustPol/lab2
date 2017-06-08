using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiukZadanieDomowe2
{
    class Bicycle : Vehicle
    {

        public Bicycle()
        {
            whoIAm = "I`m a nice bike";
            numberOfWheels = 2;
        }

        public override void Move()
        {
            //this line means that method from base class will be done 
            base.Move();
            //on next lines you can write bonus methods, that you need. Actually, in this method this line is useless
            Console.WriteLine("Instead of showing this text here would be additional results of methods that I would add.\n");
        }
    }


}

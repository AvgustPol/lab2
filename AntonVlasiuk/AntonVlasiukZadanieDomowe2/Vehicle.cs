using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiukZadanieDomowe2
{
    class Vehicle : Base 
    {
        protected bool Moving { get; set; }

        protected String whatIAmDoing;
        protected String whoIAm;
        protected int numberOfWheels;

        public Vehicle()
        {
            whatIAmDoing = "I am moving";
            whoIAm = "I`m just a vehicle";
            Moving = false;
            numberOfWheels = -1;
        }

        public override void Move()
        {
            if(!Moving)
            {
                Moving = true;
                ShowWhatAmIDoing();
            }
            else
            {
                Console.WriteLine(whatIAmDoing + "right now! I can only stop. \n");
            }
        }

        public override void Stop()
        {
            whatIAmDoing = "I am just staying here";
            Moving = false;
            ShowWhatAmIDoing();
        }

        public override bool AmIMoving()
        {
            return Moving;
        }

        public void ShowWhatAmIDoing()
        {
            Console.WriteLine(whoIAm + " and " + whatIAmDoing + "\n");
        }

        public void ShowAllInformation()
        {
            Console.WriteLine("Who I am - " + whoIAm);
            Console.WriteLine("What I am doing - " + whatIAmDoing);
            Console.WriteLine("Number of wheels - " + numberOfWheels);
            Console.WriteLine("Am I moving ? - " + Moving);
        }

    }
}

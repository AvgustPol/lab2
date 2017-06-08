using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiukZadanieDomowe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Move();
            newCar.Move();
            newCar.Stop();
            newCar.ShowAllInformation();

            Console.WriteLine("***************************");

            Bicycle newBike = new Bicycle();
            newBike.Move();
            newBike.Move();
            newBike.ShowAllInformation();

            System.Console.Read();
        }
    }
}

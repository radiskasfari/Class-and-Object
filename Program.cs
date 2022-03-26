using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_dan_Object_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Class_dan_Object_Taxi.Taxi();

            //pengesetan nilai properties
            taxi.DriveName = "Nabsyah";
            taxi.OnDuty = true;
            taxi.NumPassenger = 20;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}

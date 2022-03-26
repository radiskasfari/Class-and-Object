using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_dan_Object_Taxi
{
    public class Taxi
    {
        //properties
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriveName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriveName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriveName);
        }
    }
}
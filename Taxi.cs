using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // method
        public void TaxiInfo() 
            {
                Console.WriteLine("DriverName: {0}", DriverName);
                Console.WriteLine("OnDuty: {0}", OnDuty);
                Console.WriteLine("NumPassenger: {0}", NumPassenger);
            }

            public void PickUpPassenger()
            {
                Console.WriteLine("{0} sedang menjemput Penumpang", DriverName);
            }

            public void DropOffPassenger()
        { 
            Console.WriteLine("{0} selesai mengantar Penumpang", DriverName);
        }
    }
}

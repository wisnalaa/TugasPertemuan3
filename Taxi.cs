using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan3
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPasangger { get; set; }

        public void taxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Pasangger : {0}", NumPasangger);
        }

        public void PickUpPasangger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPasangger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }

}

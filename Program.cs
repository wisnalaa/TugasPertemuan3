using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan3 
{
    class Program
    {
        private static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPasangger = 10;

            taxi.taxiInfo();
            taxi.PickUpPasangger();
            taxi.DropOffPasangger();

            Console.ReadLine();
        }
    }
}

using RP_Övning5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5
{
    internal class Vehicle : IVehicle
    {
        public Vehicle(string reg)
        {
            RegisterID = reg;
            Name = "";
            NumberOfEngines = 0;
            CyliderVolume = 0;
            Fuletype = "None";
            NumberOfWheels = 0;
            NumberOfSeats = 1;
            Legnth = 1;
            Weight = 1;
        }
        public Vehicle(string reg, string nam)
        {
            RegisterID = reg;
            Name = nam;
            NumberOfEngines = 0;
            CyliderVolume = 0;
            Fuletype = "None";
            NumberOfWheels = 0;
            NumberOfSeats = 1;
            Legnth = 1;
            Weight = 1;
        }

        public string RegisterID { get; set; }
        public string Name { get; set; }
        public int NumberOfEngines { get; set; }
        public float CyliderVolume { get; set; }
        public string Fuletype { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int Legnth { get; set; }
        public int Weight { get; set; }
    }
}

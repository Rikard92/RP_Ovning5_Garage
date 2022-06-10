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
        public Vehicle(string reg, string name, int NumEngines, float CylVolume, string Fule, int NumfSeats, int Leg, int Wei)
        {
            RegisterID = reg;
            Name = name;
            NumberOfEngines = NumEngines;
            CyliderVolume = CylVolume;
            Fuletype = Fule;
            NumberOfSeats = NumfSeats;
            NumberOfWheels = 0;
            Legnth = Leg;
            Weight = Wei;
        }

        public Vehicle(string reg, string name, int NumEngines, float CylVolume, string Fule, int NumfSeats, int NumOfWheels, int Leg, int Wei)
        {
            RegisterID = reg;
            Name = name;
            NumberOfEngines = NumEngines;
            CyliderVolume = CylVolume;
            Fuletype = Fule;
            NumberOfSeats = NumfSeats;
            NumberOfWheels = NumOfWheels;
            Legnth = Leg;
            Weight = Wei;
        }
        public Vehicle(string reg, string name, int NumfSeats, int NumOfWheels, int Leg, int Wei)
        {
            RegisterID = reg;
            Name = name;
            NumberOfEngines = 0;
            CyliderVolume = 0;
            Fuletype = "None";
            NumberOfWheels = NumOfWheels;
            NumberOfSeats = NumfSeats;
            Legnth = Leg;
            Weight = Wei;
        }
        public Vehicle(string reg, string name)
        {
            RegisterID = reg;
            Name = name;
            NumberOfEngines = 0;
            CyliderVolume = 0;
            Fuletype = "None";
            NumberOfWheels = 0;
            NumberOfSeats = 1;
            Legnth = 0;
            Weight = 0;
        }
        public Vehicle(string name)
        {
            RegisterID = "";
            Name = name;
            NumberOfEngines = 0;
            CyliderVolume = 0;
            Fuletype = "None";
            NumberOfWheels = 0;
            NumberOfSeats = 1;
            Legnth = 0;
            Weight = 0;
        }
        public Vehicle(int NumOfWheels, int Leg, int Wei)
        {
            RegisterID = "";
            Name = "";
            NumberOfEngines = 0;
            CyliderVolume = 0;
            Fuletype = "None";
            NumberOfWheels = NumOfWheels;
            NumberOfSeats = 1;
            Legnth = Leg;
            Weight = Wei;
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

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
        public Vehicle(string reg, string nam, int wheelnum, int enginetNum, float cylvol, string fuleT, int seatNum, int legnth, int weight)
        {
            RegisterID = reg;
            Name = nam;
            NumberOfEngines = enginetNum;
            CyliderVolume = cylvol;
            Fuletype = fuleT;
            NumberOfWheels = wheelnum;
            NumberOfSeats = seatNum;
            Legnth = legnth;
            Weight = weight;
        }

        private string registerID;
        public string RegisterID {
            get
            {
                return registerID;
            }
            set
            {
                if (value == null)
                {
                    registerID = "";
                }
                else
                {
                    registerID = value;
                }
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                {
                    name = "";
                }
                else
                {
                    name = value;
                }
            }
        }
        private int numberOfEngines;
        public int NumberOfEngines
        {
            get
            {
                return numberOfEngines;
            }
            set
            {
                if (value < 0)
                {
                    numberOfEngines = 0;
                }
                else
                {
                    numberOfEngines = value;
                }
            }
        }
        private float cyliderVolume;
        public float CyliderVolume
        {
            get
            {
                return cyliderVolume;
            }
            set
            {
                if (value < 1)
                {
                    cyliderVolume = 1;
                }
                else
                {
                    cyliderVolume = value;
                }
            }
        }
        private string fuletype;
        public string Fuletype
        {
            get
            {
                return fuletype;
            }
            set
            {
                if (value == null)
                {
                    fuletype = "None";
                }
                else
                {
                    fuletype = value;
                }
            }
        }
        private int numberOfSeats;
        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }
            set
            {
                if (value < 1 )
                {
                    numberOfSeats = 1;
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }
        private int numberOfWheels;
        public int NumberOfWheels
        {
            get
            {
                return numberOfWheels;
            }
            set
            {
                if (value < 0)
                {
                    numberOfWheels = 0;
                }
                else
                {
                    numberOfWheels = value;
                }
            }
        }
        private int legnth;
        public int Legnth
        {
            get
            {
                return legnth;
            }
            set
            {
                if (value < 1)
                {
                    legnth = 1;
                }
                else
                {
                    legnth = value;
                }
            }
        }
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1)
                {
                    weight = 1;
                }
                else
                {
                    weight = value;
                }
            }
        }
    }
}

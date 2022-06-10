using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.Interfaces
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public string RegisterID { get; set; }
        public int NumberOfEngines { get; set; }
        public float CyliderVolume { get; set; }
        public string Fuletype { get; set; }
        public int NumberOfSeats {get; set; }
        public int NumberOfWheels { get; set; }
        public int Legnth { get; set; }
        public int Weight { get; set; }


    }
}

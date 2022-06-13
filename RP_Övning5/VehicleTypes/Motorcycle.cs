using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.VehicleTypes
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string reg, string nam, int wheelnum, bool Sidecar, int enginetNum, float cylvol, string fuleT, int seatNum, int legnth, int weight) : base(reg, nam, wheelnum, enginetNum, cylvol, fuleT, seatNum, legnth, weight)
        {
            HasSidecar = Sidecar;
        }
        public bool HasSidecar { get; set; }

        public override string PrintVehicle()
        {
            string returnString = base.PrintVehicle();
            
            if (HasSidecar)
            {
                returnString += $" Has a sidecart.";
            }
            return returnString;

        }
    }
}

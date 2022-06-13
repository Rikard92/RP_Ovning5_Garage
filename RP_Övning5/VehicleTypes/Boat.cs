using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.VehicleTypes
{
    internal class Boat : Vehicle
    {
        public Boat(string reg, string nam, int wheelnum, bool hasSail, int enginetNum, float cylvol, string fuleT, int seatNum, int legnth, int weight) : base(reg, nam, wheelnum, enginetNum, cylvol, fuleT, seatNum, legnth, weight)
        {
            NumberOfWheels = 0;
            HasSail = hasSail;
        }
        public bool HasSail{get;set;}

        public override string PrintVehicle()
        {
            string returnString = base.PrintVehicle();

            if (HasSail)
            {
                returnString += $" the boat has a sail.";
            }
            return returnString;

        }
    }
}

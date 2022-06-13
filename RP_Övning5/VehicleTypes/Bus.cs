using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.VehicleTypes
{
    internal class Bus: Vehicle
    {
        public Bus(string reg, string nam, int wheelnum, string busModel, int enginetNum, float cylvol, string fuleT, int seatNum, int legnth, int weight) : base(reg, nam, wheelnum, enginetNum, cylvol, fuleT, seatNum, legnth, weight)
        {
            BusModel = busModel;
            if (fuleT == "")
            {
                Fuletype = "Disle";
            }
        }

        public string BusModel { get; set; }
        public override string PrintVehicle()
        {
            string returnString = base.PrintVehicle();

            if (BusModel != null && BusModel != "")
            {
                returnString += $" {BusModel}";
            }
            return returnString;

        }
    }
}

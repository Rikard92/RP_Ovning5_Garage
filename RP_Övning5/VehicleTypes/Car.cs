using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.VehicleTypes
{
    internal class Car : Vehicle
    {
        public Car(string reg, string nam, int wheelnum, string carModel, int enginetNum, float cylvol, string fuleT, int seatNum, int legnth, int weight) : base(reg, nam, wheelnum, enginetNum, cylvol, fuleT, seatNum, legnth, weight)
        {
            CarModel = carModel;
            if (fuleT == "")
            {
                Fuletype = "Petrol";
            }
        }

        public string CarModel { get; set; }

        public override string PrintVehicle()
        {
            string returnString = base.PrintVehicle();

            if (CarModel!= null && CarModel!="")
            {
                returnString += $" {CarModel}";
            }
            return returnString;

        }
    }
}

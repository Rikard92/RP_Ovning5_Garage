using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.VehicleTypes
{
    internal class Airplane:Vehicle
    {
        public Airplane(string reg, string nam, int wingSpan, int wheelnum, int enginetNum, float cylvol, string fuleT, int seatNum, int legnth, int weight) : base(reg, nam, wheelnum, enginetNum, cylvol, fuleT, seatNum, legnth, weight)
        {
            WingSpan = wingSpan;
        }

        private int wingSpan;
        public int WingSpan
        {
            get
            {
                return wingSpan;
            }
            set
            {
                if (value < 2)
                {
                    wingSpan = 2;
                }
                else
                {
                    wingSpan = value;
                }
            }
        }
        public override string PrintVehicle()
        {
            string returnString = base.PrintVehicle() + $" wing span {WingSpan} meters.";
            
            return returnString;

        }
    }
}

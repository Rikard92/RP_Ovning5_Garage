using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.VehicleTypes
{
    internal class Car : Vehicle
    {
        public Car(string reg, string nam, string model) : base(reg, nam)
        {
            CarModel = model;
            NumberOfEngines = 1;
            Fuletype = "Petrol";
        }

        public string CarModel { get; set; }
    }
}

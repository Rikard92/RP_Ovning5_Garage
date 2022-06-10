using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5.Interfaces
{
    internal interface IHandler
    {

        public void createGarage(int size, string GarageName);

        public void createGarage(int size, string GarageName, List<Vehicle> preload);

        public List<Vehicle> ListAllVehicles(Garage<Vehicle> garage);

        public List<String> ListAllVehicleTypes(Garage<Vehicle> garage);

        public string AddVehicle(Garage<Vehicle> garage, Vehicle vehicle);

        public void RemoveVehicle(Garage<Vehicle> garage, Vehicle vehicle);

        public Vehicle FindVehicleByRegister(Garage<Vehicle> garage, string register);

        public Vehicle FindVehicleByName(Garage<Vehicle> garage, string name);

        public List<Vehicle> FindVehiclesByfeatures(Garage<Vehicle> garage, Vehicle example);

        public void RemoveAllVehicles(Garage<Vehicle> garage);

        public int GetGarageCapacity(Garage<Vehicle> garage);


    }
}

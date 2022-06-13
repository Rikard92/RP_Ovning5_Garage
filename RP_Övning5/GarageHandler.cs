using RP_Övning5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5
{
    internal class GarageHandler
    {
        private List<Garage<Vehicle>> GarageRegistry;

        public GarageHandler()
        {
            GarageRegistry = new List<Garage<Vehicle>>();
        }

        public List<Garage<Vehicle>> getGarageRegistry()
        {
            return GarageRegistry;
        }

        public void createGarage(int size, string GarageName)
        {
            Garage<Vehicle> Hanger = new Garage<Vehicle>(size);
            Hanger.GarageName = GarageName;

            GarageRegistry.Add(Hanger);
        }

        public void createGarage(int size, string GarageName, List<Vehicle> preload)
        {
            Garage<Vehicle> Hanger = new Garage<Vehicle>(size);
            Hanger.GarageName = GarageName;
            foreach (Vehicle v in preload)
            {
                Hanger.Add(v);
            }
            GarageRegistry.Add(Hanger);
        }

        public string AddVehicle(Garage<Vehicle> garage, Vehicle vehicle)
        {
            string reponse;
            if (garage.Length() == garage.StoredAmount())
            {
                reponse = $"The garage {garage.GarageName} have no more space.";
            }
            else
            {
                garage.Add(vehicle);
                reponse = $"The vehicle {vehicle.RegisterID+" "}{vehicle.Name} is stored in {garage.GarageName}.";
            }

            return reponse;
        }

        public Vehicle FindVehicleByName(Garage<Vehicle> garage, string name)
        {
            var query = garage.Where(v => v.Name == name).ToList();

            return query.First();
        }

        public Vehicle FindVehicleByRegister(Garage<Vehicle> garage, string ID)
        {
            var query = garage.Where(v => v.RegisterID == ID).ToList();

            return query.First();
        }

        public List<Vehicle> FindVehiclesByfeatures(Garage<Vehicle> garage, string example)
        {
            List<Vehicle> query = garage.Where(v => v.NumberOfSeats == Int32.Parse(example) || v.NumberOfWheels == Int32.Parse(example)
            || v.NumberOfEngines == Int32.Parse(example) || v.Weight == Int32.Parse(example) || v.Legnth == Int32.Parse(example) 
            || v.CyliderVolume == Int32.Parse(example)).ToList();

            return query;
        }

        public int GetGarageCapacity(Garage<Vehicle> garage)
        {
            return garage.Length();
        }

        public List<Vehicle> ListAllVehicles(Garage<Vehicle> garage)
        {
            return garage.ToList();

        }

        public List<string> ListAllVehicleTypes(Garage<Vehicle> garage)
        {
            List<string> returnlist = new List<string>();
            foreach (var vehicle in garage)
            {
                returnlist.Add(vehicle.GetType().ToString());
            }
            returnlist = returnlist.Distinct().ToList();
            return returnlist;
        }

        public void RemoveAllVehicles(Garage<Vehicle> garage)
        {
            foreach (var vehicle in garage)
            {
                garage.Remove(vehicle);
            }
        }

        public void RemoveVehicle(Garage<Vehicle> garage, Vehicle vehicle)
        {
            garage.Remove(vehicle);
        }
    }
}

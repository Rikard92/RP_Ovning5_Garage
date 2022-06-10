using RP_Övning5.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle

    {

        public string GarageName;
        private T[] vehicles;

        public Garage(int Vtotal)
        {
            vehicles = new T[Vtotal];
        }

        public void Add(T var){
            for (int i = 0; i < vehicles.Length; i++) 
            { 
                if(vehicles[i] == null)
                {
                    vehicles[i] = var;
                    break;
                }
            }
        }

        public void Remove(T var)
        {
            vehicles = vehicles.Where(v => v.RegisterID != var.RegisterID).ToArray();
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if(vehicle is not null)
                {
                    yield return vehicle;
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int Length()
        {
            return vehicles.Length;
        }
    }
}

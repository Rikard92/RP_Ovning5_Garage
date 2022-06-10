using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning5
{
    internal class GarageUI
    {
        GarageHandler GH;

        public void Run()
        {
            GH = new GarageHandler();
            while (true)
            {
                Console.WriteLine("Pick a Garage you wish to visit: Type number or name");
                Console.WriteLine("To add a new Garage type the word 'Register'");
                DisplayGarages();

                string input = Console.ReadLine();

                if (input.Contains("Register"))
                {
                    RegisterGarage();
                }
                else
                {
                    var g = GetGarage(input);
                    if (g != null)
                    {
                        Console.Clear();

                        DisplayVehiclesInGarage(g);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again.");
                    }
                }
            }
        }
        public void DisplayGarages()
        {
            var reg = GH.getGarageRegistry();
            int i = 0;
            foreach (Garage<Vehicle> garage in reg)
            {
                i++;
                Console.WriteLine($"{i}:{garage.GarageName} Size: {garage.Count()}");
            }
        }
        public void DisplayVehiclesInGarage(Garage<Vehicle> gar)
        {
            for(int i = 1; i <= gar.Length(); i++)
            {

                if (gar.ElementAt(i) != null)
                {
                    Console.WriteLine($"[{gar.ElementAt(i).Name} {gar.ElementAt(i).RegisterID} {gar.ElementAt(i).GetType}]");
                }
                else
                {
                    Console.WriteLine($"[Empty slot]");
                }

            }
        }                
        public Garage<Vehicle> GetGarage(string input)
        {
            Garage<Vehicle> theGar = null;
            if (input.All(char.IsDigit))
            {
                theGar = GH.getGarageRegistry()[Int32.Parse(input)-1];

            }
            else
            {
                theGar = (Garage<Vehicle>?)GH.getGarageRegistry().Where(g => g.GarageName.Contains(input));
            }
            return theGar;
        }
        public void RegisterGarage()
        {
            string s = "Register";
            Console.Clear();
            while (s == "Register")
            {
                Console.WriteLine("Type the name of the new Garage.");
                string name = Console.ReadLine();
                Console.WriteLine("Type the maximum capacity of the new Garage.");
                string cap = Console.ReadLine();
                if ((cap != null && cap != "") && (name != null && name != ""))
                {
                    GH.createGarage(Int32.Parse(cap), name);
                    Console.WriteLine($"Garage '{name}' was succefully reigster.");
                    Console.WriteLine("Type the word 'Register' to add another garage, oterwise return back to the registry.");
                    s = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input.");

                }

            }
        }
    }
}

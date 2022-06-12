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
            string input = "";
            while (true)
            {
                //Visa all garage som finns
                DisplayGarages();

                input = Console.ReadLine();

                if (input.Contains("Register"))
                {
                    RegisterGarage();
                }
                else if (input.Contains("Quit") || input.Contains("quit")|| input.Contains("q"))
                {
                    break;
                }
                else
                {
                    var g = GetGarage(input);
                    string GarageInput = "";
                    if (g != null)
                    {
                        while (true)
                        {
                            Console.Clear();
                            //Visa all fordon som fins i garaget
                            DisplayVehiclesInGarage(g);
                            GarageInput = Console.ReadLine();
                            if (GarageInput.Contains("Exit"))
                            {
                                break;
                            }
                            else if(GarageInput.Contains("Add"))
                            {
                                ParkVehicle(g);



                            }
                            else if(GarageInput.Contains("Search"))
                            {
                                DisplayVehicleInformation(g, GarageInput);


                            }
                        }
                        
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again either the word 'Resister', a number form the lsit or a name of a Garage.");
                    }
                }
            }
        }

        private void ParkVehicle(Garage<Vehicle> g)
        {
            Console.WriteLine("You are able to add a vehicle of the follwing vehicle types in this garage.");
            String VehicleDesc = Console.ReadLine();
            if(VehicleDesc.Contains("Airplane") || VehicleDesc.Contains("airplane"))
            {
            }
            else if (VehicleDesc.Contains("Boat") || VehicleDesc.Contains("boat"))
            {

            }
            else if (VehicleDesc.Contains("Bus") || VehicleDesc.Contains("bus"))
            {

            }
            else if (VehicleDesc.Contains("Car") || VehicleDesc.Contains("car"))
            {

            }
            else if (VehicleDesc.Contains("Motorcycle") || VehicleDesc.Contains("motorcycle"))
            {

            }
            else
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine();
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth:");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight:");
                int Weight = Int32.Parse( Console.ReadLine());

                Vehicle vehicle = new Vehicle("ABC");
                GH.AddVehicle(g, vehicle);
            }

        }

        public void DisplayGarages()
        {
            Console.WriteLine("Pick a Garage you wish to visit: Type number or name");
            Console.WriteLine("To add a new Garage type the word 'Register'");
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
            Console.WriteLine("To add a vehicle to the garage, enter the word 'Add', to exit the garage type 'Exit'.");
            Console.WriteLine("To pick a specifick vehicle from the garage, enter the word 'Search'.");
            for (int i = 0; i < gar.Length(); i++)
            {

                if (gar.ElementAtOrDefault(i) != null)
                {
                    Console.WriteLine($"{i+1}:[{gar.ElementAt(i).Name} ID:{gar.ElementAt(i).RegisterID} Type:{gar.ElementAt(i).GetType}]");
                }
                else
                {
                    Console.WriteLine($"{i+1}:[Empty slot]");
                }

            }

        }

        public void DisplayVehicleInformation( Garage<Vehicle> G, string Input)
        {
            Console.Clear();

            Vehicle vN = GH.FindVehicleByName(G, Input);
            Vehicle vR = GH.FindVehicleByRegister(G, Input);
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
                theGar = GH.getGarageRegistry().Find(g => g.GarageName.Contains(input));
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

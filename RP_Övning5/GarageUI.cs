using RP_Övning5.VehicleTypes;
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

                input = Console.ReadLine().ToLower();

                if (input.Contains("register"))
                {
                    RegisterGarage();
                }
                else if (input.Contains("quit")|| input.Contains("q"))
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
                            GarageInput = Console.ReadLine().ToLower();
                            if (GarageInput.Contains("exit"))
                            {
                                break;
                            }
                            else if(GarageInput.Contains("add"))
                            {
                                ParkVehicle(g);



                            }
                            else if(GarageInput.Contains("search"))
                            {
                                Console.WriteLine("Type the Name, vehicle ID or the feature of the vehicle you are looking for.");

                                GarageInput = Console.ReadLine().ToLower();
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
            while (true)
            {
            Console.Clear();
            Console.WriteLine("You are able to add a vehicle of the follwing vehicle types in this garage.");
            String VehicleDesc = Console.ReadLine();
            if(VehicleDesc.Contains("Airplane") || VehicleDesc.Contains("airplane"))
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine();
                Console.Write("Wingspan (meters):");
                int wingSpan = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth (kilogram):");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight (kilogram):");
                int Weight = Int32.Parse(Console.ReadLine());

                Airplane airplane = new Airplane(RegisterID, VehicleName, NumberOfWheels, wingSpan, EnginesNum, CyliderVolume, Fuletype, NumberOfSeats, Legnth, Weight);
                Console.WriteLine(GH.AddVehicle(g, airplane));
                }
            else if (VehicleDesc.Contains("Boat") || VehicleDesc.Contains("boat"))
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine();
                Console.Write("Do the boat have a sail (yes/no):");
                string SailStr = Console.ReadLine().ToLower();
                bool Sail = false; 
                if (SailStr.Contains("n") || SailStr.Contains("no") || SailStr.Contains("dont") || SailStr.Contains("don't"))
                {
                    Sail = false;
                }
                else if (SailStr.Contains("y") || SailStr.Contains("yes") || SailStr.Contains("has sail") || SailStr.Contains("have sail") || SailStr.Contains("has a sail") || SailStr.Contains("have a sail"))
                {
                    Sail = true;
                }
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth:");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight:");
                int Weight = Int32.Parse(Console.ReadLine());

                Boat boat = new Boat(RegisterID, VehicleName, NumberOfWheels, Sail, EnginesNum, CyliderVolume, Fuletype, NumberOfSeats, Legnth, Weight);
                Console.WriteLine(GH.AddVehicle(g, boat));
                }
            else if (VehicleDesc.Contains("Bus") || VehicleDesc.Contains("bus"))
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine();
                Console.Write("Bus Modle:");
                string BusModle = Console.ReadLine();
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth:");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight:");
                int Weight = Int32.Parse(Console.ReadLine());

                Bus bus = new Bus(RegisterID, VehicleName, NumberOfWheels, BusModle, EnginesNum, CyliderVolume, Fuletype, NumberOfSeats, Legnth, Weight);
                Console.WriteLine(GH.AddVehicle(g, bus));
                }
            else if (VehicleDesc.Contains("Car") || VehicleDesc.Contains("car"))
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine(); 
                Console.Write("Car Modle:");
                string CarModle = Console.ReadLine();
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth:");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight:");
                int Weight = Int32.Parse(Console.ReadLine());

                Car car = new Car(RegisterID, VehicleName, NumberOfWheels, CarModle, EnginesNum, CyliderVolume, Fuletype, NumberOfSeats, Legnth, Weight);
                Console.WriteLine(GH.AddVehicle(g, car));
                }
            else if (VehicleDesc.Contains("Motorcycle") || VehicleDesc.Contains("motorcycle"))
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine();
                string SideStr = Console.ReadLine().ToLower();
                bool Side = false;
                if (SideStr.Contains("n") || SideStr.Contains("no") || SideStr.Contains("dont") || SideStr.Contains("don't"))
                {
                    Side = false;
                }
                else if (SideStr.Contains("y") || SideStr.Contains("yes") || SideStr.Contains("has side") || SideStr.Contains("have side") || SideStr.Contains("has a side") || SideStr.Contains("have a side"))
                {
                    Side = true;
                }
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth:");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight:");
                int Weight = Int32.Parse(Console.ReadLine());

                Motorcycle motorcyckle = new Motorcycle(RegisterID, VehicleName, NumberOfWheels, Side, EnginesNum, CyliderVolume, Fuletype, NumberOfSeats, Legnth, Weight);
                Console.WriteLine(GH.AddVehicle(g, motorcyckle));
                }
            else
            {
                Console.Write("Registerd ID:");
                string RegisterID = Console.ReadLine();
                Console.Write("Name:");
                string VehicleName = Console.ReadLine();
                Console.Write("Number Of Wheels:");
                int NumberOfWheels = Int32.Parse(Console.ReadLine());
                Console.Write("Number Of Engines:");
                int EnginesNum = Int32.Parse(Console.ReadLine());
                Console.Write("Fuletype:");
                string Fuletype = Console.ReadLine();
                Console.Write("Cylider Volume:");
                float CyliderVolume = float.Parse(Console.ReadLine());
                Console.Write("Number Of Seats:");
                int NumberOfSeats = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Legnth:");
                int Legnth = Int32.Parse(Console.ReadLine());
                Console.Write("Vehicle Weight:");
                int Weight = Int32.Parse( Console.ReadLine());

                Vehicle vehicle = new Vehicle(RegisterID, VehicleName, NumberOfWheels, EnginesNum, CyliderVolume, Fuletype, NumberOfSeats, Legnth, Weight);
                Console.WriteLine(GH.AddVehicle(g, vehicle)); 
            }
                Console.WriteLine("Do you wish to add another Vehicle?(yes/no)");
                string awnser = Console.ReadLine();
                if(awnser.Contains("no"))
                {
                    break;
                }
            }
            Console.Clear();

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
                    Console.WriteLine($"{i+1}:[{gar.ElementAt(i).Name} ID:{gar.ElementAt(i).RegisterID} Type:{gar.ElementAt(i).GetType()}]");
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

            Vehicle vN = GH.FindVehicleByName(G, Input.ToLower());
            Vehicle vR = GH.FindVehicleByRegister(G, Input.ToLower());
            if(vN != null)
            {
                Console.WriteLine(vN.PrintVehicle());
            }
            else if(vR != null)
            {
                Console.WriteLine(vR.PrintVehicle());
            }
            List<Vehicle> list = GH.FindVehiclesByfeatures(G, Input);
            foreach(Vehicle v in list)
            {

                Console.WriteLine(v.PrintVehicle());
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

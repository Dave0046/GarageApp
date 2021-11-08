using System;
using System.Linq;
using System.Collections.Generic;

namespace GarageApplication
{
    class Program
    {
        public static int  MainMenu()
        {
            Console.Clear();
            Console.WriteLine("To create Garage press number 1 ");
            Console.WriteLine("To add vehicle press number 2  ");
            Console.WriteLine("To remove vehicle press number 3 ");
            Console.WriteLine("To find vehicles press number 4 ");
            Console.WriteLine("To exit press number 5 ");
            Console.Write("Enter command number : ");
            return Convert.ToInt32(Console.ReadLine()); ;
        }
        public static string FindMenu()
        {
            Console.Clear();
            Console.WriteLine("Find a vehicle in the garage by adding a parameter."
                         + "\n1. To find with a registration number."
                         + "\n2. To find all with colour."
                         + "\n3. To find all with a specified number of wheels."
                         + "\n4. To find all with a minimum number of passengers."
                         + "\n5. To find all with cabriolet"
                         + "\n0. Exit the finding!");
            string input = Console.ReadLine();
            return input;
        }
        static void Main(string[] args)
        {
            int commandNumber;
            Garage<Vehicle> garage1 = new Garage<Vehicle>() ;
            while (true)
            {
                commandNumber = MainMenu();
                switch (commandNumber)
                {
                    case 1:
                        Console.Write("Enter Garage Name : ");
                        string garageName = Console.ReadLine();
                        garage1 = new Garage<Vehicle>(garageName);
                        Car volvoS90 = new Car("ABC 123", "Red", "Volvo", "Car", 4, 5, false);
                        Car nevs = new Car("ABD 123", "Silver", "nevs", "Car", 4, 5, false);
                        MotorCycle yamaha = new MotorCycle("ABC 124", "blue", "yamaha", "MotorCycle", 2, 200, true);
                        garage1.AddVehicle(volvoS90);
                        garage1.AddVehicle(nevs);
                        garage1.AddVehicle(yamaha);
                        break;
                    case 2:

                        break;
                    case 3:
                        string findInput=FindMenu();
                        switch (findInput)
                        {
                            case "1":
                                Console.Write("Enter registration number : ");
                                string registrationNumber = Console.ReadLine();
                                Vehicle vehicle= garage1.SearchVehicle(registrationNumber.ToUpper());
                                if (vehicle != null)
                                {
                                    Console.WriteLine(vehicle);
                                }
                                else
                                {
                                    Console.WriteLine("Not found...");
                                }
                                break;
                            case "2":
                                garage1.FindAllWithColor();
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "0":
                                commandNumber = MainMenu();
                                break;
                        }
                        break;
                    case 4:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

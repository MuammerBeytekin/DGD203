using System;
using DGD203;

namespace ProgramConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Car Color: ");
            string color = Console.ReadLine();

            Console.Write("Enter License Number: ");
            string licenseNo = Console.ReadLine();

            Console.Write("Enter Country: ");
            string make = Console.ReadLine();

            Console.Write("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Fuel Capacity: ");
            int fuelCapacity = Convert.ToInt32(Console.ReadLine());

            
            Car myCar = new Car(color, licenseNo, make, year, fuelCapacity);
            Console.WriteLine("\nCar Details:");
            Console.WriteLine(myCar.ToString());

            
            string input;
            do
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1 - Accelerate (Gas)");
                Console.WriteLine("2 - Brake");
                Console.WriteLine("3 - Show Car Details");
                Console.WriteLine("0 - Exit");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        myCar.Gas();
                        break;
                    case "2":
                        myCar.Brake();
                        break;
                    case "3":
                        Console.WriteLine(myCar.ToString());
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please choose again.");
                        break;
                }
            } while (input != "0");
        }
    }
}

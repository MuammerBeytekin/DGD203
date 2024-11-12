using System;

namespace DGD203
{
    public class Car
    {
        public Car(string color, string licenseno, string make, int year, int fuelcapacity)
        {
            Make = make;
            Color = color;
            Year = year;
            LicenseNo = licenseno;
            FuelCapacity = fuelcapacity;
            Speed = 0;  
        }

        public string Make { get; set; }
        public int Year { get; set; }
        public string LicenseNo { get; set; }
        public string Color { get; set; }
        public int FuelCapacity { get; set; }
        public int Speed { get; private set; }  

        
        public void Gas()
        {
            Speed += 10;
            Console.WriteLine($"Accelerating... Current Speed: {Speed} km/h");
        }

        
        public void Brake()
        {
            if (Speed >= 10)
            {
                Speed -= 10;
                Console.WriteLine($"Braking... Current Speed: {Speed} km/h");
            }
            else
            {
                Speed = 0;
                Console.WriteLine("The car is already stopped.");
            }
        }

        public override string ToString()
        {
            return "Make: " + Make + "\n" + "Year: " + Year + "\n" + "License No: " + LicenseNo + "\n" + "Color: " + Color + "\n" + "Fuel Capacity: " + FuelCapacity + "\n" + "Current Speed: " + Speed + " km/h";
        }
    }
}

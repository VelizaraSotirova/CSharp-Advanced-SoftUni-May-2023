using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "X5",
                Year = 2012,
                FuelConsumption = 6,
                FuelQuantity = 100
            };

            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}

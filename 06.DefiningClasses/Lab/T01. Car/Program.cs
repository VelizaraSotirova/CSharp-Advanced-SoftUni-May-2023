using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "X5",
                Year = 2012
            };
            Console.WriteLine(car.Make);
        }
    }
}

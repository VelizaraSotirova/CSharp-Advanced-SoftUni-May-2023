using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car("BMW", "X5", 2012, 100 , 2);

            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}

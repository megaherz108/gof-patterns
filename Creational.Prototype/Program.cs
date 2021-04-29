using System;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose car type:");
            Console.WriteLine("1. Passenger car");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Minivan");

            string choice = Console.ReadLine();

            CarType carType = (CarType)int.Parse(choice);

            // Get car using prototype pattern
            Car car = Car.GetCar(carType, "white", "AA777");

            Console.WriteLine($"Your card is ready: {car.Manufacturer} {car.Model}, {car.Color} color, {car.Number} number");
        }
    }
}

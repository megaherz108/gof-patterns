namespace Prototype
{
    class Car
    {
        private static Car _passengerCar = new Car
        {
            Manufacturer = "Landrover",
            Model = "Freelander",
            Type = CarType.Passenger
        };

        private static Car _truck = new Car
        {
            Manufacturer = "Ford",
            Model = "Transit",
            Type = CarType.Truck,
        };

        private static Car _minivan = new Car
        {
            Manufacturer = "Toyota",
            Model = "Hiace",
            Type = CarType.Minivan,
        };

        public string Manufacturer { get; private set; }

        public string Model { get; private set; }

        public CarType Type { get; private set; }

        public string Color { get; set; }

        public string Number { get; set; }

        // Clones existing car instance to get new car
        public static Car GetCar(CarType type, string color, string number)
        {
            Car car = null; ;

            switch(type)
            {
                case CarType.Passenger:
                    car = _passengerCar.MemberwiseClone() as Car;
                    break;

                case CarType.Truck:
                    car = _truck.MemberwiseClone() as Car;
                    break;

                case CarType.Minivan:
                    car = _minivan.MemberwiseClone() as Car;
                    break;
            }

            car.Color = color;
            car.Number = number;

            return car;
        }
    }
}

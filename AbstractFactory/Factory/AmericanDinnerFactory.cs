using AbstractFactory.Dishes;
using AbstractFactory.Dishes.American;

namespace AbstractFactory.Factory
{
    class AmericanDinnerFactory : DinnerFactory
    {
        public override Garnish CreateGarnish()
        {
            return new AmericanGarnish { Name = "Fried potato", Price = 0.5m };
        }

        public override Meat CreateMeat()
        {
            return new AmericanMeat { Name = "Meat with blood", Price = 2.5m };
        }

        public override Soup CreateSoup()
        {
            return new AmericanSoup { Name = "Tomato soup", Price = 1m };
        }
    }
}

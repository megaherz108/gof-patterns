using AbstractFactory.Dishes;
using AbstractFactory.Dishes.Ukrainian;

namespace AbstractFactory.Factory
{
    class UkrainianDinnerFactory : DinnerFactory
    {
        public override Garnish CreateGarnish()
        {
            return new UkrainianGarnish { Name = "Buckwheat", Price = 0.4m };
        }

        public override Meat CreateMeat()
        {
            return new UkrainianMeat { Name = "Kiev cutlet", Price = 1.5m };
        }

        public override Soup CreateSoup()
        {
            return new UkrainianSoup { Name = "Borsch", Price = 1.2m };
        }
    }
}

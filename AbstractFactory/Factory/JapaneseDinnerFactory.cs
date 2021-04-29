using AbstractFactory.Dishes;
using AbstractFactory.Dishes.Japanese;

namespace AbstractFactory.Factory
{
    class JapaneseDinnerFactory : DinnerFactory
    {
        public override Garnish CreateGarnish()
        {
            return new JapaneseGarnish { Name = "Rice", Price = 0.3m };
        }

        public override Meat CreateMeat()
        {
            return new JapaneseMeat { Name = "Fish", Price = 3m };
        }

        public override Soup CreateSoup()
        {
            return new JapaneseSoup { Name = "Miso soup", Price = 1m };
        }
    }
}

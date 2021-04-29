using AbstractFactory.Dishes;

namespace AbstractFactory.Factory
{
    abstract class DinnerFactory
    {
        public abstract Garnish CreateGarnish();

        public abstract Meat CreateMeat();

        public abstract Soup CreateSoup();
    }
}

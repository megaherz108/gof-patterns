using FactoryMethod.FoodTypes;

namespace FactoryMethod.Factory
{
    public class PorridgeFactory : IFoodFactory
    {
        public Food CookFood() => new Meat { Name = "Oat porridge" };
    }
}
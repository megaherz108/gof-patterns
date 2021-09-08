using FactoryMethod.FoodTypes;

namespace FactoryMethod.Factory
{
    public class MeatFactory : IFoodFactory
    {
        public Food CookFood() => new Meat { Name = "Fried meat" };
    }
}
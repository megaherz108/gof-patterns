using FactoryMethod.FoodTypes;

namespace FactoryMethod.Factory
{
    public class SoupFactory : IFoodFactory
    {
        public Food CookFood() => new Soup { Name = "Tomato soup" };
    }
}
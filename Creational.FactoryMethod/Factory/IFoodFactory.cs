using FactoryMethod.FoodTypes;

namespace FactoryMethod.Factory
{
    public interface IFoodFactory
    {
        Food CookFood();
    }
}
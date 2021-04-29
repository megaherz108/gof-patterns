using Decorator.Decorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            // Decorate pizza with cheese and bacon
            AbstractPizza normalPizza = new BaconDecorator(new CheeseDecorator(new Pizza()));
            OutputPizzaInfo(normalPizza);

            // Decorate pizza with seafood, pineapple and mushrooms
            AbstractPizza strangePizza = new MushroomsDecorator(new PineappleDecorator(new SeafoodDecorator(new Pizza())));
            OutputPizzaInfo(strangePizza);

            Console.Read();
        }

        static void OutputPizzaInfo(AbstractPizza pizza)
        {
            Console.WriteLine($"Pizza is ready: {pizza.Name} - ${pizza.GetPrice()}");
        }
    }
}

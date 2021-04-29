using Builder.Ingridients;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create pizza using builder
            var pizza = new PizzaBuilder()
                .AddIngridient(new Bacon())
                .AddIngridient(new Cheese())
                .AddIngridient(new Mushrooms())
                .AddIngridient(new Pineapple())
                .GetPizza();

            Console.WriteLine("Pizza is ready!");
        }
    }
}

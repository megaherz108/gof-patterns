using FactoryMethod.Factory;
using FactoryMethod.FoodTypes;
using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main()
        {
            do
            {
                Cook();
            }
            while (ShouldCookAgain());
        }

        private static void Cook()
        {
            IFoodFactory factory;

            try
            {
                OutputFoodTypes();

                int foodType;
                int.TryParse(Console.ReadLine(), out foodType);

                switch ((FoodType)foodType)
                {
                    case FoodType.Meat:
                        factory = new MeatFactory();
                        break;

                    case FoodType.Porridge:
                        factory = new PorridgeFactory();
                        break;

                    case FoodType.Soup:
                        factory = new SoupFactory();
                        break;

                    default:
                        throw new NotImplementedException("Can't cook this.");
                }

                // Call factory method to create object based on user input
                Food food = factory.CookFood();

                Console.WriteLine($"{food.Name} is ready. Bon appetit!");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void OutputFoodTypes()
        {
            Console.WriteLine("Select food to cook:");

            int[] values = (int[])Enum.GetValues(typeof(FoodType));

            foreach (int value in values)
            {
                Console.WriteLine($"{value} {Enum.GetName(typeof(FoodType), value)}");
            }
        }

        private static bool ShouldCookAgain()
        {
            Console.Write("Cook something else? (y / n) ");

            string answer = Console.ReadLine();

            return answer.ToLower() == "y";
        }
    }
}
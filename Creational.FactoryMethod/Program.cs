using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main()
        {
            var oven = new Oven();

            do
            {
                Cook(oven);
            }
            while (ShouldCookAgain());
        }

        private static void Cook(Oven oven)
        {
            Console.Write("Enter food name to cook: (meat / porridge / soup) ");

            string foodName = Console.ReadLine();

            try
            {
                // Call factory method to create object based on user input
                Food.Food food = oven.CreateFood(foodName.ToLower());

                Console.WriteLine($"{food.Name} is ready. Bon appetit!");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
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

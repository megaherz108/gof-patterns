using AbstractFactory.Dishes;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            Console.Write("Choose dinner type: (USA / JAP / UKR) ");
            string choice = Console.ReadLine();

            // Get concrete factory based on user's choice
            DinnerFactory dinnerFactory = GetFactory(choice);

            var dishes = new List<Dish>();

            if (dinnerFactory != null)
            {
                // Create dishes using factory
                dishes.Add(dinnerFactory.CreateGarnish());
                dishes.Add(dinnerFactory.CreateMeat());
                dishes.Add(dinnerFactory.CreateSoup());

                Console.WriteLine("Great choice! You will get:");
                foreach (Dish dish in dishes)
                {
                    Console.WriteLine($"- {dish.Name} (${dish.Price:0.##})");
                }
            }
            else
            {
                Console.WriteLine("Incorrect choice.");
            }
        }

        static DinnerFactory GetFactory(string choice)
        {
            switch (choice.ToLower())
            {
                case "usa":
                    return new AmericanDinnerFactory();

                case "jap":
                    return new JapaneseDinnerFactory();

                case "ukr":
                    return new UkrainianDinnerFactory();

                default:
                    return null;
            }
        }
    }
}

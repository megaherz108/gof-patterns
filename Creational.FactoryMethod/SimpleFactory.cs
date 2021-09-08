using FactoryMethod.FoodTypes;
using System;

namespace FactoryMethod
{
    public class SimpleFactory
    {
        public FoodTypes.Food CreateFood(string name)
        {
            switch (name)
            {
                case "meat":
                    return CreateMeat("Fried meat");

                case "porridge":
                    return CreatePorridge("Oat porridge");

                case "soup":
                    return CreateSoup("Tomato soup");

                default:
                    throw new NotImplementedException("Can't cook this yet.");
            }
        }

        public Meat CreateMeat(string name, int fryingLevel = 5)
        {
            return new Meat
            {
                Name = name,
                FryingLevel = fryingLevel
            };
        }

        public Porridge CreatePorridge(string name, string addition = "")
        {
            return new Porridge
            {
                Name = name,
                Addition = addition
            };
        }

        public Soup CreateSoup(string name, bool isCreamSoup = false)
        {
            return new Soup
            {
                Name = name,
                IsCreamSoup = isCreamSoup
            };
        }
    }
}
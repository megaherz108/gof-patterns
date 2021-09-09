using System.Collections.Generic;

namespace Command
{
    class Pizza
    {
        public List<string> Ingridients { get; private set; } = new List<string>();

        public void AddCheese()
        {
            Ingridients.Add("Cheese");
        }

        public void AddBacon()
        {
            Ingridients.Add("Bacon");
        }

        public void AddPineapple()
        {
            Ingridients.Add("Pineapple");
        }

        public void AddMushrooms()
        {
            Ingridients.Add("Mushrooms");
        }

        public void AddSeafood()
        {
            Ingridients.Add("Seafood");
        }
    }
}

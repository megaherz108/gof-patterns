using Builder.Ingridients;

namespace Builder
{
    class PizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();

        public PizzaBuilder AddIngridient(Ingridient ingridient)
        {
            _pizza.Ingridients.Add(ingridient);

            return this;
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}

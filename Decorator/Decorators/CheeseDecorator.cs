namespace Decorator.Decorators
{
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(AbstractPizza pizza) : base(pizza.Name + ", with cheese", pizza)
        {
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 1;
        }
    }
}
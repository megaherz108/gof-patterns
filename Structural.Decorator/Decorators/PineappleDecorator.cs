namespace Decorator.Decorators
{
    class PineappleDecorator : PizzaDecorator
    {
        public PineappleDecorator(AbstractPizza pizza) : base(pizza.Name + ", with pineapple", pizza)
        {
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 3;
        }
    }
}
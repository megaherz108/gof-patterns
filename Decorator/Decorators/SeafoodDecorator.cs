namespace Decorator.Decorators
{
    class SeafoodDecorator : PizzaDecorator
    {
        public SeafoodDecorator(AbstractPizza pizza) : base(pizza.Name + ", with seafood", pizza)
        {
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 4;
        }
    }
}
namespace Decorator.Decorators
{
    class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(AbstractPizza pizza) : base(pizza.Name + ", with bacon", pizza)
        {
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 5;
        }
    }
}
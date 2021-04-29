namespace Decorator.Decorators
{
    class MushroomsDecorator : PizzaDecorator
    {
        public MushroomsDecorator(AbstractPizza pizza) : base(pizza.Name + ", with mushrooms", pizza)
        {
        }

        public override int GetPrice()
        {
            return pizza.GetPrice() + 2;
        }
    }
}
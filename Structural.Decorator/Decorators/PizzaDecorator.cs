namespace Decorator.Decorators
{
    abstract class PizzaDecorator : AbstractPizza
    {
        protected AbstractPizza pizza;

        public PizzaDecorator(string name, AbstractPizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }
}

namespace Decorator
{
    abstract class AbstractPizza
    {
        public string Name { get; protected set; }

        public AbstractPizza(string name)
        {
            Name = name;
        }

        public abstract int GetPrice();
    }
}

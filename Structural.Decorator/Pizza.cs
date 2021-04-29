namespace Decorator
{
    class Pizza : AbstractPizza
    {
        public Pizza() : base("Pizza")
        {
        }

        public override int GetPrice()
        {
            return 10;
        }
    }
}

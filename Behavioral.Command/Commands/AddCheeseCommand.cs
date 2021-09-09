namespace Command.Commands
{
    class AddCheeseCommand : ICommand
    {
        private Pizza _pizza;

        public AddCheeseCommand(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void Execute()
        {
            _pizza.AddCheese();
        }
    }
}

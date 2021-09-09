namespace Command.Commands
{
    class AddPineappleCommand : ICommand
    {
        private Pizza _pizza;

        public AddPineappleCommand(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void Execute()
        {
            _pizza.AddPineapple();
        }
    }
}

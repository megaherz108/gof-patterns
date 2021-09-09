namespace Command.Commands
{
    class AddSeafoodCommand : ICommand
    {
        private Pizza _pizza;

        public AddSeafoodCommand(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void Execute()
        {
            _pizza.AddSeafood();
        }
    }
}

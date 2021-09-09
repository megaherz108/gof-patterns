namespace Command.Commands
{
    class AddMushroomsCommand : ICommand
    {
        private Pizza _pizza;

        public AddMushroomsCommand(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void Execute()
        {
            _pizza.AddMushrooms();
        }
    }
}

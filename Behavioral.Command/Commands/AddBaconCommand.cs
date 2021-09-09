namespace Command.Commands
{
    class AddBaconCommand : ICommand
    {
        private Pizza _pizza;

        public AddBaconCommand(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void Execute()
        {
            _pizza.AddBacon();
        }
    }
}

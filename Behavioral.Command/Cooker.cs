using Command.Commands;

namespace Command
{
    class Cooker
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }
    }
}

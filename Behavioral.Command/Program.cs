using Command.Commands;
using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            // Receiver
            var pizza = new Pizza();

            // Invoker
            var cook = new Cooker();

            // Add cheese
            var cheeseCommand = new AddCheeseCommand(pizza);
            cook.SetCommand(cheeseCommand);
            cook.Run();

            // Add bacon
            var baconCommand = new AddBaconCommand(pizza);
            cook.SetCommand(baconCommand);
            cook.Run();

            // Check what pizza we've got...
            Console.WriteLine("Pizza ingridients:");
            foreach(string ingridient in pizza.Ingridients)
            {
                Console.WriteLine(ingridient);
            }

            Console.Read();
        }
    }
}

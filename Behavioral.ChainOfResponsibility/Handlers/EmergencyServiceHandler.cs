using System;

namespace ChainOfResponsibility.Handlers
{
    abstract class EmergencyServiceHandler
    {
        public EmergencyServiceHandler Next { get; set; }

        public bool Result { get; set; }

        public string Description { get; set; }

        public virtual void Process()
        {
            Console.Write($"Call {Description}? ");

            Result = Console.ReadKey().KeyChar == 'y';

            Console.WriteLine();

            Next?.Process();
        }
    }
}
using ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose emergency services to call: (y / n)");

            var ambulance = new AmbulanceHandler();
            var police = new PoliceHandler { Next = ambulance };
            var firefighters = new FireHandler { Next = police };

            var handlers = new List<EmergencyServiceHandler> { firefighters, police, ambulance };

            // Start processing for the first handler in chain
            firefighters.Process();

            Console.WriteLine("Done, you have called:");

            foreach(EmergencyServiceHandler handler in handlers)
            {
                if (handler.Result == true)
                {
                    Console.WriteLine(handler.Description);
                }
            }
        }
    }
}
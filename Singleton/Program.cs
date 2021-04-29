using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var myInstances = new List<Lazy<Multiton>>();

            // Create max number of multiton objects
            for (var i = 0; i < Multiton.MAX_INSTANCES + 1; i++)
            {
                try
                {
                    var multiton = Multiton.CreateInstance();
                    myInstances.Add(multiton);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Remove some instance
            myInstances[5].Value.Dispose();

            Console.WriteLine($"Current number of instances: {Multiton.InstancesCount}");

            Console.Read();
        }
    }
}

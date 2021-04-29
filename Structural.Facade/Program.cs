using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            // Initialize facade
            var facade = new CalculatorFacade();

            // Call web service using facade
            int sum = facade.Add(2, 2);
            Console.WriteLine(sum);

            int multiply = facade.Multiply(3, 3);
            Console.WriteLine(multiply);

            Console.Read();
        }
    }
}

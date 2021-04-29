using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            var proxy = new CalculatorProxy();

            int result = proxy.Multiply(1024, 768);
            Console.WriteLine(result);

            // Try to get result of the same operation from cache
            int cachedResult = proxy.Multiply(1024, 768);
            Console.WriteLine(cachedResult);

            Console.Read();
        }
    }
}

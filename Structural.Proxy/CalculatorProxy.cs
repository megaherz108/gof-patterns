using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    class CalculatorProxy : ICalculator
    {
        private List<KeyValuePair<string, int>> _cache = new List<KeyValuePair<string, int>>();

        private CalculatorFacade _facade = new CalculatorFacade();

        private int Calculate(Func<int, int, int> func, int intA, int intB)
        {
            // Generate operation key
            string key = $"{intA}{func.Method.Name}{intB}";

            // Try to get result from cache
            if (_cache.Any(c => c.Key == key))
            {
                var cachedRecord = _cache.FirstOrDefault(c => c.Key == key);

                return cachedRecord.Value;
            }
            // Otherwise get result from web service
            else
            {
                int result = func.Invoke(intA, intB);

                _cache.Add(new KeyValuePair<string, int>(key, result));

                return result;
            }
        }

        public int Add(int intA, int intB)
        {
            return Calculate(_facade.Add, intA, intB);
        }

        public int Divide(int intA, int intB)
        {
            return Calculate(_facade.Divide, intA, intB);
        }

        public int Multiply(int intA, int intB)
        {
            return Calculate(_facade.Multiply, intA, intB);
        }

        public int Subtract(int intA, int intB)
        {
            return Calculate(_facade.Subtract, intA, intB);
        }
    }
}

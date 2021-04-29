using System;
using System.Collections.Generic;
using System.Linq;

namespace Singleton
{
    class Multiton : IDisposable
    {
        public const int MAX_INSTANCES = 10;

        private static List<Lazy<Multiton>> _instances = new List<Lazy<Multiton>>();

        public static int InstancesCount
        {
            get
            {
                return _instances.Count;
            }
        }

        public static Lazy<Multiton> CreateInstance()
        {
            if (_instances.Count < MAX_INSTANCES)
            {
                var instance = new Lazy<Multiton>();

                _instances.Add(instance);

                Console.WriteLine($"Instance {_instances.Count} is created");

                return instance;
            }
            else
            {
                throw new Exception("Max number of instances is reached");
            }
        }

        public void Dispose()
        {
            var instance = _instances.FirstOrDefault(i => i.Value == this);

            _instances.Remove(instance);

            Console.WriteLine($"Instance is disposed");
        }
    }
}

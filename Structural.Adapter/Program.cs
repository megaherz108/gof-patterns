using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            var adapter = new Adapter();

            // Call methods of original class using adapter
            adapter.WriteSomething();
            adapter.Beep();

            Console.Read();
        }
    }
}

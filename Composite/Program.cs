using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            // Create some tree
            var rootNode = new Node
            {
                Children = new List<TreeElement>
                {
                    new Leaf(),
                    new Node
                    {
                        Children = new List<TreeElement>
                        {
                            new Leaf(),
                            new Leaf()
                        }
                    }
                }
            };

            // Increase value for all nodes and leaves using composite pattern
            rootNode.IncreaseValue();

            Console.Read();
        }
    }
}

using System.Collections.Generic;

namespace Composite
{
    class Node : TreeElement
    {
        public List<TreeElement> Children = new List<TreeElement>();

        public override void IncreaseValue()
        {
            Value++;

            Children.ForEach(c => c.IncreaseValue());
        }

        public override void DecreaseValue()
        {
            Value--;

            Children.ForEach(c => c.DecreaseValue());
        }
    }
}

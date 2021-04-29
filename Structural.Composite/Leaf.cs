namespace Composite
{
    class Leaf : TreeElement
    {
        public override void IncreaseValue()
        {
            Value++;
        }

        public override void DecreaseValue()
        {
            Value--;
        }
    }
}

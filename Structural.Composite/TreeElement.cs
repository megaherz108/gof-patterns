namespace Composite
{
    abstract class TreeElement
    {
        private int _value = 0;

        public int Value
        {
            get
            {
                return _value;
            }
            protected set
            {
                _value = value;
            }
        }

        public abstract void IncreaseValue();

        public abstract void DecreaseValue();
    }
}

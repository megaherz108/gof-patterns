namespace Adapter
{
    class Adapter
    {
        private readonly МойКласс _myClassObject = new МойКласс();

        public void WriteSomething()
        {
            _myClassObject.НаписатьЧтоНибудь();
        }

        public void Beep()
        {
            _myClassObject.ИздатьЗвук();
        }
    }
}

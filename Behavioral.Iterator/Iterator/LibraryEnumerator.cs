namespace Iterator.Iterator
{
    class LibraryEnumerator : IBookEnumerator
    {
        IBookEnumerable _collection;

        int _index = 0;

        public LibraryEnumerator(IBookEnumerable collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _index < _collection.Count;
        }

        public Book Next()
        {
            return _collection[_index++];
        }
    }
}

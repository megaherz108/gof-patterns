namespace Iterator.Iterator
{
    interface IBookEnumerable
    {
        IBookEnumerator GetAuthorEnumerator();
        IBookEnumerator GetTitleEnumerator();
        IBookEnumerator GetYearEnumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}

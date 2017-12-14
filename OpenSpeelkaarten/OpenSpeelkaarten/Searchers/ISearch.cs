namespace OpenSpeelkaarten.Searchers
{
    interface ISearch<T, U>
    {
        bool BinarySearch(U list, T target);
    }
}

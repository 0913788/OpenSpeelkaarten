namespace OpenSpeelkaarten.Comparator
{
    interface IComparator<T>
    {
        int Compare(T searchTarget, T source);
    }
}

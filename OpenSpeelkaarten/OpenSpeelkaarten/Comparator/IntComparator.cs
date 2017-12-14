namespace OpenSpeelkaarten.Comparator
{
    class IntComparator : IComparator<int>
    {

        public int Compare(int searchTarget, int source)
        {
            if (searchTarget > source) return 1;
            else if (searchTarget == source) return 0;
            else return -1;
        }
    }
}

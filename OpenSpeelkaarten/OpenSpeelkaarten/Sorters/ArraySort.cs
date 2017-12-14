using OpenSpeelkaarten.Comparator;
using OpenSpeelkaarten.Sorters.Array;

namespace OpenSpeelkaarten.Sorters
{
    class ArraySort<T>: AbsArraySort<T>
    {
        public ArraySort(IComparator<T> comparator)
        {
            this.comparator = comparator;
        }
    }
}

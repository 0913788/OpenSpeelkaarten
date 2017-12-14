using OpenSpeelkaarten.Comparator;
using System;

namespace OpenSpeelkaarten.Sorters.Array
{
    abstract class AbsArraySort<T> : ISort<T, T[]>
    {
        protected IComparator<T> comparator;

        public T[] InsertionSort(T[] list)
        {
            throw new NotImplementedException();
        }
    }
}

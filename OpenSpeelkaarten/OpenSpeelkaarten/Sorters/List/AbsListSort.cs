using OpenSpeelkaarten.Comparator;
using System;
using System.Collections.Generic;

namespace OpenSpeelkaarten.Sorters.List
{
    class AbsListSort<T> : ISort<List<T>, T>
    {
        protected IComparator<T> comparator;
        public T InsertionSort(T list)
        {
            throw new NotImplementedException();
        }
    }
}

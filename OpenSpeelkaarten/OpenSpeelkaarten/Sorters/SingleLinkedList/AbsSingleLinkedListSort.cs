using OpenSpeelkaarten.Comparator;
using OpenSpeelkaarten.Structures.SLL;
using System;

namespace OpenSpeelkaarten.Sorters.SingleLinkedList
{
    class AbsSingleLinkedListSort<T> : ISort<ISingleLinkedList<T>, T>
    {
        protected IComparator<T> comparator;
        public T InsertionSort(T list)
        {
            throw new NotImplementedException();
        }
    }
}

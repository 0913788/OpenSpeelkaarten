using OpenSpeelkaarten.Comparator;
using OpenSpeelkaarten.Structures.SLL;
using System;

namespace OpenSpeelkaarten.Searchers.SingleLinkedList
{
    class AbsSingleLinkedListSearch<T> : ISearch<ISingleLinkedList<T>, T>
    {
        protected IComparator<T> comparator;
        public bool BinarySearch(T list, ISingleLinkedList<T> target)
        {
            throw new NotImplementedException();
        }
    }
}

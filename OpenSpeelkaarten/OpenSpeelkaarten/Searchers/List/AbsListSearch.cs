using OpenSpeelkaarten.Comparator;
using System;
using System.Collections.Generic;

namespace OpenSpeelkaarten.Searchers.List
{
    class AbsListSearch<T> : ISearch<List<T>, T>
    {
        protected IComparator<T> comparator;    
        public bool BinarySearch(T list, List<T> target)
        {
            throw new NotImplementedException();
        }
    }
}

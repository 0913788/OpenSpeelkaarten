namespace OpenSpeelkaarten.Searchers
{
    interface ISearch<T, U>
    {
        /// <summary>
        /// Perform a binary search on a given list.
        /// </summary>
        /// <param name="list">The list in which you would like to search.</param>
        /// <param name="target">The value that you're searching for.</param>
        /// <returns>Boolean, true = found and false = not found</returns>
        bool BinarySearch(U list, T target);
    }
}

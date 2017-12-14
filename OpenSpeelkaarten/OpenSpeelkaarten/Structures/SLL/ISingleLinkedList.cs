using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;

namespace OpenSpeelkaarten.Structures.SLL
{
    interface ISingleLinkedList<T>
    {
        void Insert(T value);
        void InsertAtEnd(T value);
        void InsertAfter(T value, T targetValue);
        void DeleteHead();
        void DeleteEnd();
        void DeleteSpecific(T value);
        void Display();
        ISingleLinkedListNode<T> GetHead();
    }
}

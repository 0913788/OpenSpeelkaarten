namespace OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes
{
    interface ISingleLinkedListNode<T>
    {
        bool IsEmpty();
        ISingleLinkedListNode<T> GetNext();
        T GetValue();
        void SetTail(ISingleLinkedListNode<T> tail);
        void Disconnect();
    }
}

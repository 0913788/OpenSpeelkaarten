namespace OpenSpeelkaarten.Structures.Stack
{
    interface IStack<L,T>
    {
        T Pop();
        T Peek();
        void Push(T value);
        bool IsEmpty();
    }
}

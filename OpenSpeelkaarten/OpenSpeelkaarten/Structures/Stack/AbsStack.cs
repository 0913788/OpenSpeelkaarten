namespace OpenSpeelkaarten.Structures.Stack
{
    abstract class AbsStack<L, T> : IStack<L, T>
    {
        protected L elements;
        abstract public bool IsEmpty();
        abstract public T Peek();
        abstract public T Pop();
        abstract public void Push(T value);
    }
}

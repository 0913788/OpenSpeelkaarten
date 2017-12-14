namespace OpenSpeelkaarten.Structures.Queue
{
    abstract class AbsQueue<L, T> : IQueue<L, T>
    {
        protected L elements;

        abstract public T Dequeue();

        abstract public void Display();

        abstract public void Enqueue(T value);
    }
}

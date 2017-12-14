namespace OpenSpeelkaarten.Structures.Queue
{
    interface IQueue<L, T>
    {
        void Enqueue(T value);

        T Dequeue();

        void Display();
    }
}

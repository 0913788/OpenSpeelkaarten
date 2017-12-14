using OpenSpeelkaarten.Structures.Nodes.TreeNodes;

namespace OpenSpeelkaarten.Structures.Tree
{
    interface ITree<T>
    {
        void Add(T value, ITreeNode<T> node);
        void Remove(T value);
        void TraversePreOrder(ITreeNode<T> node);
        void TraversePostOrder(ITreeNode<T> node);
        void TraverseInOrder(ITreeNode<T> node);
    }
}

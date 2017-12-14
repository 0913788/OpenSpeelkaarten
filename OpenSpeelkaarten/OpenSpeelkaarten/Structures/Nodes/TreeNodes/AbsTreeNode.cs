using System;

namespace OpenSpeelkaarten.Structures.Nodes.TreeNodes
{
    abstract class AbsTreeNode<T> : ITreeNode<T>
    {
        protected T value;
        protected ITreeNode<T> leftNode = null, rightNode = null, parentNode;

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetLeftChild()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetParentNode()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetRightChild()
        {
            throw new NotImplementedException();
        }

        public T GetValue()
        {
            throw new NotImplementedException();
        }

        public bool IsLeaf()
        {
            throw new NotImplementedException();
        }

        public void SetLeftChild(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void SetPartentNode(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void SetRightChild(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public ITreeNode<T> GetLeftNode()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetParentNode()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetRightNode()
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

        public void SetLeftNode(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void SetPartentNode(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void SetRightNode(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }
    }
}

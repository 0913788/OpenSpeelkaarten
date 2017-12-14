namespace OpenSpeelkaarten.Structures.Nodes.TreeNodes
{
    interface ITreeNode<T>
    {
        T GetValue();
        ITreeNode<T> GetParentNode();
        void SetPartentNode(ITreeNode<T> node);
        ITreeNode<T> GetLeftNode();
        void SetLeftNode(ITreeNode<T> node);
        ITreeNode<T> GetRightNode();
        void SetRightNode(ITreeNode<T> node);
        bool IsLeaf();
        void Disconnect();
    }
}

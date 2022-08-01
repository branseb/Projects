namespace BinaryTree
{
    public class Node<T, K> //where K : IComparable    
    {
        public readonly T Data;
        public readonly K Key;

        public Node<T, K> Left { get; set; }

        public Node<T, K> Right { get; set; }

        public Node(K key, T data)
        {
            Key = key;
            Data = data;
        }

    }
}

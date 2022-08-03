namespace BinaryTree
{
    public class BinaryTree<T, K> where K : IComparable
    {
        private Node<T, K> Root { get; set; }

        public void Add(K key, T data)
        {
            if (Root == null)
            {
                Root = new Node<T, K>(key, data);
            }

            else
            {
                var node = Root;
                while (true)
                {

                    if (node.Key.CompareTo(key) > 0)//ide do lava
                    {
                        if (node.Left == null)
                        {
                            var x = new Node<T, K>(key, data);
                            node.Left = x;
                            break;
                        }
                        else
                        {
                            node = node.Left;
                            continue;
                        }
                    }
                    else if (node.Key.CompareTo(key) < 0)//ide do prava
                    {
                        if (node.Right == null)
                        {
                            var x = new Node<T, K>(key, data);
                            node.Right = x;
                            break;
                        }
                        else
                        {
                            node = node.Right;
                            continue;
                        }
                    }
                    else
                    {
                        throw new Exception("Car whit this licenceplace exist!");
                        break;
                    }

                }
            }

        }

        public T Get(K key)
        {
            if (Root == null)
            {
                return default;
            }
            else
            {
                var node = Root;
                while (true)
                {
                    if (node.Key.CompareTo(key) > 0)//ide do lava
                    {
                        if (node.Left != null)
                        {
                            if (node.Left.Key.CompareTo(key) == 0)
                            {
                                return node.Left.Data;
                            }
                            else
                            {
                                node = node.Left;
                                continue;
                            }
                        }
                        else
                        {
                            throw new Exception("Car no exist in Databese!");
                        }
                    }
                    else if (node.Key.CompareTo(key) < 0)//ide do prava
                    {
                        if (node.Right != null)
                        {
                            if (node.Right.Key.CompareTo(key) == 0)
                            {
                                return node.Right.Data;
                            }
                            else
                            {
                                node = node.Right;
                                continue;
                            }
                        }
                        else
                        {
                            throw new Exception("Car no exist in Databese!");
                        }
                    }
                    else
                    {
                        return node.Data;
                    }

                }
            }

        }

    }
}

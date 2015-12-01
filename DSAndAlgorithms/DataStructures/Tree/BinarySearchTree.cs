using System;
using System.Collections.Generic;

namespace DSAndAlgorithms.DataStructures.Tree
{
    public class BinarySearchTree<E> where E: IComparable
    {
        #region Fields
        private Node<E> root;

        #endregion

        #region Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        #endregion

        #region Properties
        public Node<E> Root
        {
            get
            {
                return root;
            }
            
        }

#endregion
        public void Add(E data)
        {
            Node<E> parent = null;
            var current = Root;

            int ret=0;

            while (current!=null)
            {
                parent = current;
                ret = data.CompareTo(current.data);

                if (ret == 0)
                {
                    return;
                }

                if (ret < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            var tempNode = new Node<E> {data = data};
            if (parent != null)
            {
                if (ret < 0)
                {
                    parent.Left = tempNode;
                }
                else
                {
                    parent.Right = tempNode;
                }
            }
            else
            {
                root = tempNode;
            }
        }

        public void Remove(E data)
        {
            root = AuxillaryRemove(Root, data);
        }

        private Node<E> AuxillaryRemove(Node<E> current, E data)
        {
            if (current == null)
            {
                return null;
            }

            int ret = data.CompareTo(current.data);

            if (ret < 0)
            {
                current.Left = AuxillaryRemove(current.Left, data);
            }
            else if (ret > 0)
            {
                current.Right = AuxillaryRemove(current.Right, data);
            }
            else
            {
                // Case 3

                if (current.Left != null && current.Right != null)
                {
                    E val = FindSmallestInRightSubTree(current.Right);
                    current.data = val;
                    current.Right = AuxillaryRemove(current.Right, val);
                }
                else
                {
                    // Case 1 and 2

                    return current.Left ?? current.Right;
                }
            }

            return current;
        }

        private E FindSmallestInRightSubTree(Node<E> node)
        {
            var current = node.Left;
            while (current.Left!=null)
            {
                continue;
            }

            return current.data;
        }

        public void Preorder(Node<E> Root)
        {
            if (Root != null)
            {
                Console.Write(Root.data + " ");
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }

        public void LevelOrder(Node<E> root)
        {
            var queue = new Queue<Node<E>>();
            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count!=0)
            {
                var node = queue.Dequeue();
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);   
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
                
                Console.WriteLine(node.data);
            }


        }

        public void Inorder(Node<E> Root)
        {
           if (Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.data + " ");
                Inorder(Root.Right);
            }
        }

        public void Postorder(Node<E> Root)
        {
            if (Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                Console.Write(Root.data + " ");
            }
        }

        //public bool PathSum(Node<E> node, E sum)
        //{
        //    if (node == null)
        //    {
        //        return sum == 0;
        //    }
            
        //        int subsum = sum - node.item;

        //        return PathSum(node.leftChild, subsum) || PathSum(node.rightChild, subsum);
        //}

        public int Size(Node<E> root)
        {

            if (root == null)
            {
                return 0;
            }
            else
            {
                return Size(root.Left) + 1 + Size(root.Right);
            }
        }

        //public int Minimum(Node root)
        //{
        //    Node current = root;
        //    Node parent = null;
        //    while (current!=null)
        //    {
        //        parent = current;
        //        current = current.leftChild;
        //    }
        //    if (parent == null)
        //    {
        //        return 0;
        //    }

        //    return parent.item;
        //}

        //public int Maximum(Node root)
        //{
        //    Node current = root;
        //    Node parent = null;
        //    while (current != null)
        //    {
        //        parent = current;
        //        current = current.rightChild;
        //    }
        //    if (parent == null)
        //    {
        //        return 0;
        //    }

        //    return parent.item;
        //}

        //public static bool AreTwoTreesEqual(Node root1, Node root2)
        //{
        //    if (root1 == null && root2 == null)
        //    {
        //        return true;
        //    }

        //    if ((root1.item == root2.item) && root1 != null && root2 != null)
        //    {
        //        return AreTwoTreesEqual(root1.leftChild, root2.leftChild) && AreTwoTreesEqual(root1.rightChild, root2.rightChild);
        //    }
            
        //    return false;
        //}
    }
}
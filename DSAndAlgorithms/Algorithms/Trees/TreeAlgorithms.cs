using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSAndAlgorithms.DataStructures.Tree;

namespace DSAndAlgorithms.Algorithms.Trees
{
    static class TreeAlgorithms<E>
    {
        public static void Mirror(Node<E> root)
        {
            if (root == null || (root.Left==null && root.Right==null))
            {
                return;
            }

            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;

            Mirror(root.Left);
            Mirror(root.Right);
        }

        //// TODO: Given a tree, print all the nodes which are K distance from the leaf nodes.
        /// We can use recursion here, and in each left and right calls reduce the distance by 1.
        /// Keep a check that if distance finally becomes 0, print the node. 
        public static void PrintAllRootToLeafPaths(Node<E> current, E[] path, int pathLength )
        {


        }


    }
}

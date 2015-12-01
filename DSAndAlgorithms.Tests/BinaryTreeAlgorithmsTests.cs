using System;
using DSAndAlgorithms.DataStructures.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;
using DSAndAlgorithms.Algorithms.Trees;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class BinarySearchTreeAlgorithmsTests
    {
        [TestMethod]
        public void BinaryTreeAlgorithms_Test()
        {
            var tree1 = new BinarySearchTree<int>();
            tree1.Add(24);
            tree1.Add(12);
            tree1.Add(15);
            tree1.Add(67);
            tree1.Add(32);
            tree1.Add(13);
            tree1.Add(89);
            tree1.Add(9);

         


            tree1.Remove(13);
            tree1.Remove(24);
            //Assert.IsTrue(tree1.PathSum(tree1.Root(), 45));
            //Assert.IsTrue(tree1.PathSum(tree1.Root(), 51));
            //Assert.IsFalse(tree1.PathSum(tree1.Root(), 42));

            //Assert.AreEqual(8, tree1.Size(tree1.Root()));

            //Assert.AreEqual(9, tree1.Minimum(tree1.Root()));

            //Assert.AreEqual(89, tree1.Maximum(tree1.Root()));

            //Assert.IsTrue(BinaryTree.AreTwoTreesEqual(tree1.Root(), tree2.Root()));

            Console.WriteLine("Inorder traversal ");
            tree1.Inorder(tree1.Root);
            Console.WriteLine(" ");

            TreeAlgorithms<int>.Mirror(tree1.Root);

            Console.WriteLine("Inorder traversal of the Mirror tree");
            tree1.Inorder(tree1.Root);
            Console.WriteLine(" ");

            Console.WriteLine();
            Console.WriteLine("Preorder traversal");
            tree1.Preorder(tree1.Root);
            Console.WriteLine(" ");

            Console.WriteLine();
            Console.WriteLine("Postorder traversal");
            tree1.Postorder(tree1.Root);
            Console.WriteLine(" ");
        }

        [TestMethod]
        public void BinaryTreeAlgorithms_Mirror_Test()
        {
            var tree1 = new BinarySearchTree<int>();
            tree1.Add(24);
            tree1.Add(12);
            tree1.Add(15);
            tree1.Add(67);
            tree1.Add(32);
            tree1.Add(13);
            tree1.Add(89);
            tree1.Add(9);

            Console.WriteLine("Inorder traversal ");
            tree1.Inorder(tree1.Root);
            Console.WriteLine(" ");

            TreeAlgorithms<int>.Mirror(tree1.Root);

            Console.WriteLine("Inorder traversal of the Mirror tree");
            tree1.Inorder(tree1.Root);
            Console.WriteLine(" ");
          
        }
    }
}

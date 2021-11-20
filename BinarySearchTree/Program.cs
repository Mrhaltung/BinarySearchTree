using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program.");
            BinaryTree binarytree = new BinaryTree();

            BinaryTree obj1 = new BinaryTree();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);

            Console.Write("Inorder result : ");
            obj1.TraverseInorder(obj1.root);
            Console.WriteLine();

            Console.Write("Post-order result : ");
            obj1.TraversePostorder(obj1.root);
            Console.WriteLine();

            Console.Write("Pre-order result : ");
            obj1.TraversePreorder(obj1.root);
            Console.WriteLine();
        }
    }
}

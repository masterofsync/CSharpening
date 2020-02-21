using System;
using System.Collections.Generic;
using bSearchTree = BinarySearchTreeDLLNamespace.BinarySearchTree;

namespace BinarySearchTreeTestApplicationNamespace
{
    class BST
    {
        private static readonly List<int> arrayBSTValues = new List<int>() { 8, 6, 11, 4, 7, 15, 14 };

        static void Main(string[] args)
        {
            // Initialize 
            var bst = new bSearchTree(null);

            BSTRecursiveImplementation(bst);
            BSTIterativeImplementation(bst);

            Console.ReadKey();
        }

        public static void BSTRecursiveImplementation(bSearchTree bst)
        {
            #region Recursive BST

            // Insert Data
            arrayBSTValues.ForEach(x => bst.InsertRecursively(x));

            // Maximum Depth
            Console.WriteLine($"Maximum Depth:{bst.MaximumDepthRecursively()}");

            // Search for Data

            // Delete specific Data

            // Modify Data

            // Display all data

            bst.DisplayInOrderRecursively();
            Console.WriteLine();
            bst.DisplayPreOrderRecursively();
            Console.WriteLine();
            bst.DisplayPostOrderRecursively();
            Console.WriteLine();
            #endregion
        }

        public static void BSTIterativeImplementation(bSearchTree bst)
        {
            #region Iterative BST
            // Just add recursively for now
            //arrayBSTValues.ForEach(x => bst.InsertIteratively(x));

            // Display all data
            Console.WriteLine("Inorder Iteratively:");
            bst.DisplayInOrderIteratively();
            Console.WriteLine();
            Console.WriteLine("Preorder Iteratively:");
            bst.DisplayPreOrderIteratively();
            Console.WriteLine();
            Console.WriteLine("Postorder Iteratively:");
            bst.DisplayPostOrderIteratively();
            Console.WriteLine();


            Console.WriteLine(bst.ContainsIteratively(14));
            Console.WriteLine(bst.ContainsIteratively(8));
            Console.WriteLine(bst.ContainsIteratively(1));
            #endregion
        }
    }
}

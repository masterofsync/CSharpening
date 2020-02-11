using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    interface IBinarySearchTree
    {
        void Insert(int val);
        bool Contains(int val);
        void DisplayPreOrder();
        void DisplayInOrder();
        void DisplayPostOrder();
        void ReOrder();
    }

    /// <summary>
    /// Binary Tree Node
    /// </summary>
    public class Node
    {
        public int Value { get; private set; }

        public Node left;
        public Node right;
        public Node(int val)
        {
            this.Value = val;
        }
    }

    public class BinarySearchTreeRecursively : IBinarySearchTree
    {
        private Node root;

        public BinarySearchTreeRecursively(Node root)
        {
            this.root = root;
        }

        /// <summary>
        /// Insert Value in Node
        /// </summary>
        /// <param name="val">Integer Value</param>
        public void Insert(int val)
        {
            try
            {
                InsertRecursively(ref root, val);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                // ref such that the updates made in the node reflect the local root node variable.
                void InsertRecursively(ref Node node, int value)
                {
                    if (node == null)
                    {
                        node = new Node(val);
                        return;
                    }

                    // if value supplied is greater, go right
                    if (val > node.Value)
                    {
                        InsertRecursively(ref node.right, value);
                        return;
                    }

                    // if value is smaller, go left
                    if (val < node.Value)
                    {
                        InsertRecursively(ref node.left, value);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Check if value is in the BST
        /// </summary>
        /// <param name="val">Integer Value</param>
        /// <returns></returns>
        public bool Contains(int val)
        {
            return ContainsRecursively(root, val);

            /*
             * Check if the current node is null & current node value matches the given value
             * if val is smaller than the node value go left else go right
             */

            // local function
            bool ContainsRecursively(Node node, int value)
            {
                if (node == null)
                    return false;

                if (node.Value == value)
                    return true;

                if (value < node.Value)
                {
                    return ContainsRecursively(node.left, value);
                }
                else if (value > node.Value)
                {
                    return ContainsRecursively(node.right, value);
                }

                return false;
            }
        }

        // Display all the values in the BST

        /// <summary>
        /// Display data Pre-order
        /// </summary>
        public void DisplayPreOrder()
        {
            try
            {
                Node tempNode = root;

                DisplayInOrderRecursively(tempNode);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                void DisplayInOrderRecursively(Node node)
                {
                    // print the value
                    Console.WriteLine(node.Value);
                    // Go to the left most leaf
                    if (node.left != null)
                    {
                        DisplayInOrderRecursively(node.left);
                    }

                    // Go to the right
                    if (node.right != null)
                    {
                        DisplayInOrderRecursively(node.right);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Display data In-order
        /// </summary>
        public void DisplayInOrder()
        {
            try
            {
                Node tempNode = root;

                DisplayInOrderRecursively(tempNode);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                void DisplayInOrderRecursively(Node node)
                {
                    // Go to the left most leaf
                    if (node.left != null)
                    {
                        DisplayInOrderRecursively(node.left);
                    }

                    // print the value
                    Console.WriteLine(node.Value);

                    // Go to the right
                    if (node.right != null)
                    {
                        DisplayInOrderRecursively(node.right);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Display data Post-order
        /// </summary>
        public void DisplayPostOrder()
        {
            try
            {
                Node tempNode = root;

                DisplayInOrderRecursively(tempNode);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                void DisplayInOrderRecursively(Node node)
                {
                    // Go to the left most leaf
                    if (node.left != null)
                    {
                        DisplayInOrderRecursively(node.left);
                    }

                    // Go to the right
                    if (node.right != null)
                    {
                        DisplayInOrderRecursively(node.right);
                    }

                    // print the value
                    Console.WriteLine(node.Value);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ReOrder()
        {
            throw new NotImplementedException();
        }
    }

    public class BinarySearchTreeIteratively : IBinarySearchTree
    {
        public bool Contains(int val)
        {
            throw new NotImplementedException();
        }

        public void DisplayInOrder()
        {
            throw new NotImplementedException();
        }

        public void DisplayPostOrder()
        {
            throw new NotImplementedException();
        }

        public void DisplayPreOrder()
        {
            throw new NotImplementedException();
        }

        public void Insert(int val)
        {
            throw new NotImplementedException();
        }

        public void ReOrder()
        {
            throw new NotImplementedException();
        }
    }

    class BST
    {
        static void Main(string[] args)
        {
            // Initialize 

            var recursiveBST = new BinarySearchTreeRecursively(null);

            // Insert Data
            recursiveBST.Insert(8);
            recursiveBST.Insert(6);
            recursiveBST.Insert(11);
            recursiveBST.Insert(4);
            recursiveBST.Insert(7);
            recursiveBST.Insert(15);
            recursiveBST.Insert(14);

            // Search for Data

            // Delete specific Data

            // Modify Data

            // Display all data
            Console.WriteLine("In-Order:");
            recursiveBST.DisplayInOrder();
            Console.WriteLine();
            Console.WriteLine("Pre-Order:");
            recursiveBST.DisplayPreOrder();
            Console.WriteLine();
            Console.WriteLine("Post-Order:");
            recursiveBST.DisplayPostOrder();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTreeDLLNamespace
{
    interface IBinarySearchTree
    {
        // recursive
        void InsertRecursively(int val);
        bool ContainsRecursively(int val);
        void DisplayPreOrderRecursively();
        void DisplayInOrderRecursively();
        void DisplayPostOrderRecursively();
        void ReOrderRecursively();

        // iterative
        void InsertIteratively(int val);
        bool ContainsIteratively(int val);
        void DisplayPreOrderIteratively();
        void DisplayInOrderIteratively();
        void DisplayPostOrderIteratively();
        void ReOrderIteratively();
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

    public class BinarySearchTree : IBinarySearchTree
    {
        public Node root;

        public BinarySearchTree(Node root)
        {
            this.root = root;
        }

        #region Recursively
        /// <summary>
        /// Insert Value in Node
        /// </summary>
        /// <param name="val">Integer Value</param>
        public void InsertRecursively(int val)
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
        public bool ContainsRecursively(int val)
        {
            try
            {
                return ContainsRecursively(root, val);

                /*
                 * Check if the current node is null & current node value matches the given value
                 * if val is smaller than the node value go left else go right
                 */

                // local function
                bool ContainsRecursively(Node node, int value)
                {
                    try
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
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Display all the values in the BST

        /// <summary>
        /// Display data Pre-order
        /// </summary>
        public void DisplayPreOrderRecursively()
        {
            try
            {
                Node tempNode = root;

                Console.WriteLine("Pre-Order Recursively:");

                DisplayPreOrderRecursively(tempNode);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                void DisplayPreOrderRecursively(Node node)
                {
                    try
                    {
                        // print the value
                        Console.WriteLine(node.Value);
                        // Go to the left most leaf
                        if (node.left != null)
                        {
                            DisplayPreOrderRecursively(node.left);
                        }

                        // Go to the right
                        if (node.right != null)
                        {
                            DisplayPreOrderRecursively(node.right);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
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
        public void DisplayInOrderRecursively()
        {
            try
            {
                Node tempNode = root;

                Console.WriteLine("In-Order Recursively:");

                DisplayInOrderRecursively(tempNode);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                void DisplayInOrderRecursively(Node node)
                {
                    try
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
                    catch (Exception)
                    {
                        throw;
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
        public void DisplayPostOrderRecursively()
        {
            try
            {
                Node tempNode = root;
                Console.WriteLine("Post-Order Recursively:");

                DisplayPostOrderRecursively(tempNode);

                // local function such that user need not send a node as parameter & keeping track of node is easier
                void DisplayPostOrderRecursively(Node node)
                {
                    try
                    {
                        // Go to the left most leaf
                        if (node.left != null)
                        {
                            DisplayPostOrderRecursively(node.left);
                        }

                        // Go to the right
                        if (node.right != null)
                        {
                            DisplayPostOrderRecursively(node.right);
                        }

                        // print the value
                        Console.WriteLine(node.Value);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ReOrderRecursively()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Iteratively
        /// <summary>
        /// Display Tree data in order iteratively
        /// </summary>
        public void DisplayInOrderIteratively()
        {
            try
            {
                // Solving using a stack
                Stack<Node> stack = new Stack<Node>();

                Node tempNode = root;

                while (tempNode != null || stack.Any())
                {
                    // Iterate to the left most; the first item for in order traversal.
                    while (tempNode != null)
                    {
                        stack.Push(tempNode);
                        tempNode = tempNode.left;
                    }

                    tempNode = stack.Pop();
                    Console.WriteLine(tempNode.Value);
                    tempNode = tempNode.right;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertIteratively(int val)
        {
            throw new NotImplementedException();
        }

        public bool ContainsIteratively(int val)
        {
            throw new NotImplementedException();
        }

        public void DisplayPreOrderIteratively()
        {
            throw new NotImplementedException();
        }

        public void DisplayPostOrderIteratively()
        {
            throw new NotImplementedException();
        }

        public void ReOrderIteratively()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

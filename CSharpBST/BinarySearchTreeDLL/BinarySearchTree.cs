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

        /// <summary>
        /// Insert Iteratively given integer value.
        /// </summary>
        /// <param name="val"></param>
        public void InsertIteratively(int val)
        {
            /*
             * While loop, 
             * if user submitted val is smaller than node value:
             * check if left is null, if it is, create new node with the val else go left
             * if user submitted val is greater than node value:
             * check if right is null, if it is, create new node with the val else go right
             */
            try
            {
                var tempNode = this.root;

                if (tempNode == null)
                {
                    root = new Node(val);
                    tempNode = root;
                    return;
                }

                while (true)
                {
                    if (val < tempNode.Value)
                    {
                        if (tempNode.left == null)
                        {
                            tempNode.left = new Node(val);
                            break;
                        }
                        else
                        {
                            tempNode = tempNode.left;
                        }
                    }
                    else // if equal or greater
                    {
                        if (tempNode.right == null)
                        {
                            tempNode.right = new Node(val);
                            break;
                        }
                        else
                        {
                            tempNode = tempNode.right;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Check if bst contains the value provided by user.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool ContainsIteratively(int val)
        {
            /*
             * Assuming a balanced BST: Do same as for insert, 
             * except check for val equals instead of adding new node. O(logn)
             * If not balanced, do inorder search and return true. O(n) worst.
             */

            if (root == null)
                return false;

            var tempNode = root;

            #region balanced
            //while (tempNode!=null)
            //{
            //    if(val==tempNode.Value)
            //    {
            //        return true;
            //    }
            //    else if(val<tempNode.Value)
            //    {
            //        if(tempNode.left!=null)
            //        {
            //            tempNode = tempNode.left;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else if(val>tempNode.Value)
            //    {
            //        if(tempNode.right!=null)
            //        {
            //            tempNode = tempNode.right;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //}
            //return false;
            #endregion

            #region unbalanced
            if (tempNode.Value == val) return true;

            Stack<Node> nodesStack = new Stack<Node>();

            while (tempNode != null || nodesStack.Any())
            {
                // Iterate to the left most; the first item for in order traversal.
                while (tempNode != null)
                {
                    if (tempNode.Value == val) return true;
                    nodesStack.Push(tempNode);
                    tempNode = tempNode.left;
                }

                tempNode = nodesStack.Pop();

                if (tempNode.Value == val) return true;

                tempNode = tempNode.right;
            }
            return false;

            #endregion
        }

        public void DisplayPreOrderIteratively()
        {
            Stack<Node> nodesStack = new Stack<Node>();

            var tempNode = root;

            while (nodesStack.Any() || tempNode != null)
            {
                // traverse all the way to the left & push nodes to stack
                while (tempNode!= null)
                {
                    Console.WriteLine(tempNode.Value);
                    nodesStack.Push(tempNode);
                    tempNode = tempNode.left;
                }
                tempNode = nodesStack.Pop();
                tempNode = tempNode.right;
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    public class BinarySearchTree
    {
        //Class cotaining the node structure
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        Node root;

        //Constructor
        public BinarySearchTree() { root = null; }
        public BinarySearchTree(int value) { root = new Node(value); }

        //Calling our recursive function, InsertRecursive
        public void Insert(int key)
        {
            root = InsertRecursive(root, key);
        }

        //Inserting a new node into the Binary Search Tree
        Node InsertRecursive(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if(key < root.key)
            {
                root.left = InsertRecursive(root.left, key);
            }
            else if (key > root.key)
            {
                root.right = InsertRecursive(root.right, key);
            }

            return root;
        }

        //Calling our recursive function, InOrderTraversalRecursive
        public void InOrderTraversal() 
        { 
            InOrderTraversalRecursive(root); 
        }

        //In-Order Traversal of the Binary Search Tree
        public void InOrderTraversalRecursive(Node root)
        {
            if (root != null)
            {
                InOrderTraversalRecursive(root.left);
                Console.Write($"{root.key} ");
                InOrderTraversalRecursive(root.right);
            }
        }


    }
}

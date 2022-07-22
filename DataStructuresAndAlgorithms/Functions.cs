using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Functions
    {
        public static void PrintBinaryTreeInOrder(Node<int> root)
        {
            if (root == null)
                return;
            
            if (root.left != null)
            {
                PrintBinaryTreeInOrder(root.left);
            }
            else
            {
                Console.Write(root.Data +", ");
                root = root.parent;
                root.left = null;
                if (root.right != null)
                {
                    Console.Write(root.Data + ", ");
                    PrintBinaryTreeInOrder(root.right);
                }
                else
                    PrintBinaryTreeInOrder(root);
            }
        }
    }
}

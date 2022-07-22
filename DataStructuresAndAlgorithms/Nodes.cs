using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Node<T>
    {
        public Node(T data, Node<T> Parent)
        {
            Data = data;
            parent = Parent;
        }
        public T Data;

        public Node<T> left;
        public Node<T> right;
        public Node<T> parent;
    }

    public class WorkingWithNodes
    {
        public static Node<int> DoSomething()
        {
            Node<int> root = new Node<int>(10, null);
            var node1 = new Node<int>(15, root);
            var node2 = new Node<int>(3, node1);
            var node3 = new Node<int>(6, node1);
            var node4 = new Node<int>(5, node2);
            var node5 = new Node<int>(30, root);
            var node6 = new Node<int>(2, node5);
            var node7 = new Node<int>(9, node6);
            var node8 = new Node<int>(8, node6);

            root.left = node1; root.right = node5;
            node1.left = node2; node1.right = node3;
            node2.left = node4;
            node5.right = node6;
            node6.left = node7; node6.right = node8;

            return root;
        }
    }
}

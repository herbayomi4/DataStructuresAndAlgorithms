using System;

namespace DataStructuresAndAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //Trasversing through a Binary Tree
            var root = WorkingWithNodes.DoSomething();//Setting up the tree
            Functions.PrintBinaryTreeInOrder(root);//Print in "InOrder" fashion i.e LVR - Left Node, Visit Root, Right Node
        }

    }
}

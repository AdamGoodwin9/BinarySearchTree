using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //new List<int> { 20, 15, 17, 2, 6, 3, 8 }.BinarySearch(3);
            
            

            
            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(2);
            
            Console.ReadKey();
        }
    }
}
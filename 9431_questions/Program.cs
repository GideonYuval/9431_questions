using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDLR;
using Unit4.CollectionsLib;

namespace _9431_questions
{
    internal class Program
    {
        //     Tree 1                      Tree 2
        //        1                           1
        //       / \                         / \
        //      2   3                       2   2

        // Tree3:                            // Tree4:
        //        3                            //        6
        //       / \                           //       / \
        //      4   3                          //      7   6
        //     / \    \                        //     / \    \
        //    5   6    3                       //    6   6    6
        //           /                          //       /  \  
        //          8                           //      6    7  
        //         / \                          
        //        8   7
        //        

        // Tree5:
        //        8
        //       / \
        //      3   10
        //     / \    \
        //    1   6    14
        //       / \   /
        //      4   7 13


        static void Main(string[] args)
        {
            //Q1
            /*
            VisualTree<int>.DrawTree(BuildTree1());
            BinNode<int> b = BuildTree1();
            AddLevel(b);
            VisualTree<int>.DrawTree(b);
            */

            //Q2
            BinNode<int> b1 = BuildTree1();
            DoubleLeft(b1);
            VisualTree<int>.DrawTree(b1);

            //Q3
            Console.WriteLine(TreeWeight(BuildTree5())); //14


            //Q4
            Console.WriteLine(MinTransitions(BuildTree3())); //1
            Console.WriteLine(MinTransitions(BuildTree4())); //0

            //Q5
            //Console.WriteLine(AreEqual(BuildTree1(), BuildTree1()));
            //Console.WriteLine(AreEqual(BuildTree1(), BuildTree2()));


        }

        //Q1
        //under each leaf, add a left leaf with value=leaf value-1, right leaf=leaf value+1
        static void AddLevel(BinNode<int> root)
        {
        }

        //Q2
        //if a node has 2 children, add a new left child between the node and left node
        //value of new node = value of current node
        //       Before:                       After 
        //        1                              1
        //       / \                            / \
        //      2   3                          1   3
        //     / \                            /
        //    4   5                          2
        //                                  / \
        //                                 2   5
        //                                /
        //                               4
        static void DoubleLeft(BinNode<int> root)
        {

        }

        //Q3
        //return the maximum absolute difference between left and right children. null = 0
        // Tree5:
        //        8
        //       / \
        //      3   10
        //     / \    \
        //    1   6    14
        //       / \   /
        //      4   7 13

        // Expected calculation for TreeWeight:
        // - Node 8: |3 - 10| = 7
        // - Node 3: |1 - 6| = 5
        // - Node 10: |0 - 14| = 14
        // - Node 6: |4 - 7| = 3
        // - Node 14: |13 - 0| = 13
        // - Leaf nodes (1, 4, 7, 13) have no children → difference = 0

        // Maximum absolute difference = 14 (Node 10)
        static int TreeWeight(BinNode<int> root)
        {
            return 0;
        }

        //Q4
        //return the minimum number of transitions from root to leaf in a tree
        //example: root:5->5->6->3 = 2 transitions

        static int MinTransitions(BinNode<int> root)
        {
            return 0;
        }


        //Q5
        //return true if 2 trees are equal, false if not
        static bool AreEqual(BinNode<int> t1, BinNode<int> t2)
        {
            return false;
        }


        public static BinNode<int> BuildTree1()
        {

            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left child
            root.SetLeft(new BinNode<int>(2));

            // Right child
            root.SetRight(new BinNode<int>(3));

            return root;
        }

        public static BinNode<int> BuildTree2()
        {

            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left child
            root.SetLeft(new BinNode<int>(2));

            // Right child
            root.SetRight(new BinNode<int>(2));

            return root;
        }

        public static BinNode<int> BuildTree3()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(3);

            // Left subtree
            BinNode<int> node4 = new BinNode<int>(4);
            node4.SetLeft(new BinNode<int>(5));
            node4.SetRight(new BinNode<int>(6));

            // Right subtree
            BinNode<int> node3Right = new BinNode<int>(3);
            BinNode<int> node8 = new BinNode<int>(8);
            node8.SetLeft(new BinNode<int>(8));
            node8.SetRight(new BinNode<int>(7));

            node3Right.SetLeft(node8);

            // Attach left and right subtrees
            root.SetLeft(node4);
            root.SetRight(node3Right);

            return root;
        }

        public static BinNode<int> BuildTree4()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(6);

            // Left subtree
            BinNode<int> node7 = new BinNode<int>(7);
            node7.SetLeft(new BinNode<int>(6));
            node7.SetRight(new BinNode<int>(6));

            // Right subtree
            BinNode<int> node6Right = new BinNode<int>(6);
            BinNode<int> node6Child = new BinNode<int>(6);
            node6Child.SetLeft(new BinNode<int>(6));
            node6Child.SetRight(new BinNode<int>(7));

            node6Right.SetRight(node6Child);

            // Attach left and right subtrees
            root.SetLeft(node7);
            root.SetRight(node6Right);

            return root;
        }

        public static BinNode<int> BuildTree5()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(8);

            // Left subtree
            BinNode<int> node3 = new BinNode<int>(3);
            node3.SetLeft(new BinNode<int>(1));

            BinNode<int> node6 = new BinNode<int>(6);
            node6.SetLeft(new BinNode<int>(4));
            node6.SetRight(new BinNode<int>(7));

            node3.SetRight(node6);

            // Right subtree
            BinNode<int> node10 = new BinNode<int>(10);
            BinNode<int> node14 = new BinNode<int>(14);
            node14.SetLeft(new BinNode<int>(13));

            node10.SetRight(node14);

            // Attach left and right subtrees
            root.SetLeft(node3);
            root.SetRight(node10);

            return root;
        }



    }



}

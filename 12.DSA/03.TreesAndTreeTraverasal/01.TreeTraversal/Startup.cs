/*You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), each in the range (0..N-1).

Write a program to read the tree and find:
    the root node
    all leaf nodes
    all middle nodes
    the longest path in the tree
    (*) all paths in the tree with given sum `S` of their nodes
    (*) all subtrees with given sum `S` of their nodes

7
2 4
3 2
5 0
3 5
5 6
5 1

Root: 3; Leafs: 0, 1, 6, 4; Middle nodes: 5, 2; Longest path - 2

9
11 666
2 4
3 2
5 0
3 5
5 6
5 1
4 11

Root: 3, Leafs: 0, 1, 6, 666; Middle nodes: 5, 2, 4, 11; Longest path - 4

6
Ivan Stamat
Pesho Gosho
Gosho Ivan
Gosho Maria
Pesho Karagioz

Root: Pesho; Leafs: Stamat, Karagioz, Maria; Middle nodes: Gosho, Ivan; Longest path - 3
*/

namespace _01.TreeTraversal
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dictionary = Tree.CreateTreeDictionary<string>(n);

            var tree = Tree.CreateTreeFromDictionary(dictionary);
            Console.WriteLine("\r\nThe root is: {0}\r\n", tree.Value);

            var leafs = Tree.FindLeafNodes(tree);
            Console.WriteLine("Leafs:");
            Tree.PrintTreeNodes(leafs);

            var middleNodes = Tree.FindMiddleNodes(tree);
            Console.WriteLine("Middle nodes:");
            Tree.PrintTreeNodes(middleNodes);

            var longestPath = Tree.FindLognestPath(tree);
            Console.WriteLine("Longest path is: {0}", longestPath);
        }
    }
}

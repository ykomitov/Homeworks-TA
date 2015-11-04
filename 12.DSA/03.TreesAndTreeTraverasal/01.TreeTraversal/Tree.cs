namespace _01.TreeTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Tree
    {
        public static Dictionary<string, List<string>> CreateTreeDictionary<T>(int numberOfNodes)
        {
            var tree = new Dictionary<string, List<string>>();

            for (int i = 1; i < numberOfNodes; i++)
            {
                var nodeAsString = Console.ReadLine();
                var nodeAsArray = nodeAsString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var parentIndex = nodeAsArray[0];
                var child = nodeAsArray[1];

                if (!tree.ContainsKey(parentIndex))
                {
                    tree[parentIndex] = new List<string>();
                }

                tree[parentIndex].Add(child);
            }

            return tree;
        }

        public static Node<T> BuildTreeFromDictionary<T>(Dictionary<string, List<string>> treeDict, Node<T> root)
        {
            var treeNode = root;

            return treeNode;
        }

        // Problem 1.1 - Create the tree from the dictionary (then we have the root node ;)
        public static Node<T> CreateTreeFromDictionary<T>(Dictionary<T, List<T>> dictionary)
        {
            var treeNodes = new Dictionary<T, bool>();

            foreach (var item in dictionary)
            {
                if (!treeNodes.ContainsKey(item.Key))
                {
                    treeNodes.Add(item.Key, false);
                }

                foreach (var child in item.Value)
                {
                    if (treeNodes.ContainsKey(child))
                    {
                        treeNodes[child] = true;
                        continue;
                    }

                    treeNodes.Add(child, true);
                }
            }

            foreach (var node in treeNodes)
            {
                if (node.Value == false)
                {
                    var rootNode = new Node<T>();
                    rootNode.Value = node.Key;
                    rootNode.Children = GetChildNodes(dictionary, rootNode.Value);
                    return rootNode;
                }
            }

            throw new Exception("No root node has been found!");
        }

        // Problem 1.2 - Find all leafs
        public static List<Node<T>> FindLeafNodes<T>(Node<T> node)
        {
            var listOfLeafs = new List<Node<T>>();

            if (node.Children.Count == 0)
            {
                listOfLeafs.Add(node);
            }

            foreach (var child in node.Children)
            {
                if (child.Children.Count == 0)
                {
                    listOfLeafs.Add(child);
                }
                else
                {
                    foreach (var ch in child.Children)
                    {
                        listOfLeafs.AddRange(FindLeafNodes(ch));
                    }
                }
            }

            return listOfLeafs;
        }

        public static void PrintTreeNodes<T>(List<Node<T>> leafs)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < leafs.Count; i++)
            {
                sb.Append(leafs[i].Value);

                if (i < leafs.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        // Problem 1.3 - Middle nodes
        public static List<Node<T>> FindMiddleNodes<T>(Node<T> node)
        {
            var middleNodes = new List<Node<T>>();

            foreach (var n in node.Children)
            {
                if (n.Children.Count > 0)
                {
                    middleNodes.Add(n);
                    middleNodes.AddRange(FindMiddleNodes(n));
                }
            }

            return middleNodes;
        }

        // Problem 1.4 - Longest Path
        public static int FindLognestPath<T>(Node<T> node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int path = 0;
            foreach (var child in node.Children)
            {
                path = Math.Max(path, FindLognestPath(child));
            }

            return path + 1;
        }

        private static List<Node<T>> GetChildNodes<T>(Dictionary<T, List<T>> dictionary, T value)
        {
            var nodeList = new List<Node<T>>();

            if (dictionary.ContainsKey(value))
            {
                foreach (var item in dictionary[value])
                {
                    var nodeToAdd = new Node<T>
                    {
                        Value = item,
                        HasParent = true,
                        Children = GetChildNodes(dictionary, item)
                    };

                    nodeList.Add(nodeToAdd);
                }
            }

            return nodeList;
        }
    }
}

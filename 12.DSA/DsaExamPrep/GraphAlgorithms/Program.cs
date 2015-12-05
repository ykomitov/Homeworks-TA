namespace GraphAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static string input = @"1 2
3 1
3 6
4 5
3 6
2 5
3 4
3 5
7 8
6 7";

        public static void Main()
        {
            // The number of vertices in the graph
            int n = 8;

            // The number of edges
            int m = 10;

            // Build Graph as an adjacency list

            // The adjacency list, holding the graph
            List<int>[] vertices = new List<int>[n];

            var edges = input.Split('\n');

            foreach (var edge in edges)
            {
                var parts = edge.Split(' ');
                var v1 = int.Parse(parts[0]) - 1;
                var v2 = int.Parse(parts[1]) - 1;

                // Initialization test
                if (vertices[v1] == null)
                {
                    vertices[v1] = new List<int>();
                }

                if (vertices[v2] == null)
                {
                    vertices[v2] = new List<int>();
                }

                vertices[v1].Add(v2);
                vertices[v2].Add(v1); // It is a non-oriented graph
            }

            //Bfs(vertices, 0);

            var visited = new HashSet<int>();
            Dfs(vertices, new Node { Vertex = 1, Level = 0 }, visited);
        }

        private static void Dfs(List<int>[] vertices, Node v, HashSet<int> visited)
        {
            if (visited.Contains(v.Vertex))
            {
                return;
            }

            Console.WriteLine(v.Vertex + 1);

            visited.Add(v.Vertex);

            foreach (var neighbour in vertices[v.Vertex])
            {
                var next = new Node
                {
                    Vertex = neighbour,
                    Level = v.Level + 1
                };

                Dfs(vertices, next, visited);
            }
        }

        private static void Bfs(List<int>[] vertices, int v)
        {
            Queue<Node> queue = new Queue<Node>();
            bool[] visited = new bool[vertices.Length]; // We can also use a HashSet<int>
            int[] path = new int[vertices.Length];

            queue.Enqueue(new Node
            {
                Vertex = v,
                Level = 0
            });

            visited[v] = true;
            path[v] = -1;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine("{0} -> level {1}", current.Vertex + 1, current.Level + 1);

                // If graph is oriented, check if any neighbours exist
                if (vertices[current.Vertex] == null)
                {
                    continue;
                }

                // Check if visited and add to queue
                foreach (var neighbour in vertices[current.Vertex])
                {
                    if (!visited[neighbour])
                    {
                        queue.Enqueue(new Node
                        {
                            Vertex = neighbour,
                            Level = current.Level + 1
                        });

                        visited[neighbour] = true;
                        path[neighbour] = current.Vertex;
                    }
                }
            }

            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine("{0} <- {1}", i + 1, path[i] + 1);
            }

            var index = 7;
            var pathFound = new List<int>();
            pathFound.Add(index + 1);

            while (path[index] != -1)
            {
                pathFound.Add(path[index] + 1);
                index = path[index];
            }

            pathFound.Reverse();
            Console.WriteLine(string.Join(" -> ", pathFound));
        }
    }

    public class Node
    {
        public int Vertex { get; set; }

        public int Level { get; set; }
    }
}

namespace ActualExam_02
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Dependencies = new List<Node>();
        }

        public int Value { get; set; }

        public List<Node> Dependencies { get; set; }
    }

    public class Program2
    {
        public static void MockInput()
        {
            var input = @"3
4 8 16
0
0
1 2";

            Console.SetIn(new StringReader(input));
        }

        public static List<int>[] dependencies;
        public static int[] times;
        public static bool[] visited;

        public static void Main()
        {

            // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<REMOVE
            //MockInput();

            var n = int.Parse(Console.ReadLine());
            times = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            dependencies = new List<int>[n];
            visited = new bool[n];
            var totalTimes = new List<int>();

            for (int i = 0; i < n; i++)
            {
                dependencies[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            }

            for (int i = 0; i < times.Length; i++)
            {
                if (visited[i] != true)
                {
                    visited[i] = true;
                    var node = new Node(times[i]);

                    if (dependencies[i].Count > 0)
                    {
                        foreach (var dep in dependencies[i])
                        {
                            node.Dependencies.Add(new Node())

                        }
                    }
                }
            }

            //int sumOfDep = 0;
            //bool countOfDepAlwaysOne = true;
            //foreach (var item in dependencies)
            //{
            //    if (item.Count > 1)
            //    {
            //        countOfDepAlwaysOne = false;
            //    }
            //    foreach (var subitem in item)
            //    {
            //        sumOfDep += subitem;
            //    }
            //}

            //if (sumOfDep == 0)
            //{
            //    var maxTime = 0;
            //    for (int i = 0; i < times.Length; i++)
            //    {
            //        if (times[i] > maxTime)
            //        {
            //            maxTime = times[i];
            //        }
            //    }

            //    Console.WriteLine(maxTime);
            //    return;
            //}

            //var totalTime = 0;

            //for (int i = 0; i < times.Length; i++)
            //{
            //    if (visited[i] == true)
            //    {
            //        continue;
            //    }

            //    totalTime += times[i];

            //    if (dependencies[i].Count > 0)
            //    {
            //        int timeOfDependencies = CalculateTimeOfDependencies(dependencies[i]);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(-1);
            //}

            //for (int i = 0; i < times.Length; i++)
            //{
            //    if (visited[i] != true)
            //    {
            //        var timeOfTask = times[i];
            //        visited[i] = true;

            //        int timeOfDependencies = 0;
            //        if (dependencies[i] != 0)
            //        {
            //            timeOfDependencies = CalculateTimeOfDependencies(dependencies[i]);
            //        }

            //        timeOfTask += timeOfDependencies;
            //        totalTimes.Add(timeOfTask);
            //    }
            //}

            //int totalTime = 0;
            //foreach (var t in totalTimes)
            //{
            //    totalTime += t;
            //}

            //Console.WriteLine(totalTime);
            //for (int i = 1; i < times.Length; i++)
            //{
            //    if (dependencies[i] != 0)
            //    {
            //        var dependentTask = i;
            //        var otherTask = dependencies[dependencies[i]] + 1;

            //        if (otherTask < dependencies.Length && i == dependencies[otherTask])
            //        {
            //            Console.WriteLine(-1);
            //        }
            //    }
            //}
        }

        //private static int CalculateTimeOfDependencies(List<int> list)
        //{
        //    var time = 0;

        //    if (list.Count == 0)
        //    {
        //        return 0;
        //    }

        //    foreach (var dep in collection)
        //    {

        //    }
        //}

        //private static int CalculateTimeOfDependencies(int index)
        //{
        //    int count = 0;
        //    if (visited[index - 1] == true)
        //    {
        //        return 0;
        //    }

        //    visited[index - 1] = true;
        //    if (dependencies[0][index - 1] == 0)
        //    {
        //        count += times[index - 1];
        //    }
        //    else
        //    {
        //        count += CalculateTimeOfDependencies(dependencies[0][index - 1]);
        //        count += times[index - 1];
        //    }

        //    return count;
        //}
    }
}

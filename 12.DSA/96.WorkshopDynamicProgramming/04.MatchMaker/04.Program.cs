namespace _04.MatchMaker
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static string input = @"6
Pesho
m
1
ski
Gosho
m
3
chalga ski batman
Ivancho
m
2
batman ski
Mariika
f
1
chalga
Petra
f
3
chalga batman ski
Elena
f
1
batman";

        static Dictionary<string, List<string>> vertices;
        static HashSet<string> guys;
        static HashSet<string> gals;

        public static void Main()
        {
            MockInput();
            ReadInput();
            Solve();
        }

        private static void Solve()
        {
            foreach (var gal in gals)
            {
                // do BFS
                Queue<string> queue = new Queue<string>();
                HashSet<string> visited = new HashSet<string>();
                var matches = new Dictionary<string, List<string>>(); //???

                queue.Enqueue(gal);

                while (queue.Count > 0)
                {
                    matches.Clear();
                    queue.Clear();

                    var current = queue.Dequeue();

                    foreach (var next in vertices[current])
                    {
                        // next may be a guy => stop 
                        if (guys.Contains(next))
                        {
                            if (matches.ContainsKey(next))
                            {
                                matches[next] = 0;
                            }

                            matches[next]++;
                        }
                        else
                        {
                            queue.Enqueue(next);
                        }
                    }

                    // All matches found

                // Check best match && ordering OR reverse logic
                }
            }
        }

        private static void ReadInput()
        {
            //initialize guys and gals

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var gender = Console.ReadLine();
                var _ = Console.ReadLine();
                var interests = Console.ReadLine().Split(' ');

                string from;
                string to;
                foreach (var interest in interests)
                {
                    if (gender == "f")
                    {
                        from = name;
                        to = interest;
                        gals.Add(name);
                    }
                    else
                    {
                        from = interest;
                        to = name;
                        guys.Add(name);
                    }

                    if (vertices.ContainsKey(from))
                    {
                        vertices[from] = new List<string>();
                    }
                    vertices[from].Add(to);
                }
            }
        }

        private static void MockInput()
        {
            Console.SetIn(new StringReader(input));
        }
    }
}

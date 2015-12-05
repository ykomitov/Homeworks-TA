namespace DsaExam_Portals
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            // MockInput(); // Do not forget to comment when submitting to BGCoder

            var startPos = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int x = startPos[0];
            int y = startPos[1];

            var matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int r = matrixSize[0];
            int c = matrixSize[1];

            var labyrinth = new Cell[r, c];

            for (int i = 0; i < r; i++)
            {
                var lineAsArr = Console.ReadLine().Split(' ').ToArray();

                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    int value = 0;
                    bool isPassable = int.TryParse(lineAsArr[j], out value);

                    labyrinth[i, j] = new Cell(new Address(i, j), isPassable, value, false);
                }
            }

            CalculateChildAddresses(labyrinth);

            ulong answer = DfsMax(labyrinth, labyrinth[x, y]);

            Console.WriteLine(answer);
        }

        private static ulong DfsMax(Cell[,] labyrinth, Cell cell)
        {
            var labCopy = (Cell[,])labyrinth.Clone();

            cell.isVisited = true;

            if (cell == null)
            {
                return 0;
            }

            var list = new List<ulong>();

            foreach (var child in cell.ChildAddresses)
            {
                if (!labCopy[child.R, child.C].isVisited && labCopy[child.R, child.C].isPassable)
                {
                    list.Add(DfsMax(labCopy, labCopy[child.R, child.C]));
                }
            }

            ulong listMax = 0;
            foreach (var item in list)
            {
                if (item > listMax)
                {
                    listMax = item;
                }
            }

            return listMax + (ulong)cell.Value;
        }

        private static int MaxSum(Cell[,] labyrinth, int x, int y)
        {
            int sum = 0;

            var stack = new Stack<Cell>();
            stack.Push(labyrinth[x, y]);
            sum += labyrinth[x, y].Value;

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current.Address.R + current.Value < labyrinth.GetLength(0)
                    && labyrinth[current.Address.R + current.Value, current.Address.C].isPassable)
                {
                    current.ChildAddresses.Add(new Address(current.Address.R + current.Value, current.Address.C));
                }

                if (current.Address.R - current.Value >= 0
                    && labyrinth[current.Address.R - current.Value, current.Address.C].isPassable)
                {
                    current.ChildAddresses.Add(new Address(current.Address.R - current.Value, current.Address.C));
                }

                if (current.Address.C + current.Value < labyrinth.GetLength(1)
                    && labyrinth[current.Address.R, current.Address.C + current.Value].isPassable)
                {
                    current.ChildAddresses.Add(new Address(current.Address.R, current.Address.C + current.Value));
                }

                if (current.Address.C - current.Value >= 0
                    && labyrinth[current.Address.R, current.Address.C - current.Value].isPassable)
                {
                    current.ChildAddresses.Add(new Address(current.Address.R, current.Address.C - current.Value));
                }

                foreach (var node in current.ChildAddresses)
                {
                    var currentCell = labyrinth[node.R, node.C];

                    if (!currentCell.isVisited)
                    {
                        sum += currentCell.Value;
                        currentCell.isVisited = true;
                        stack.Push(currentCell);
                    }
                }
            }

            return sum;
        }

        private static int MaxSumPower(Cell[,] labyrinth, Cell cell)
        {
            cell.isVisited = true;

            var sum = 0;
            foreach (var child in cell.ChildAddresses)
            {
                if (!labyrinth[child.R, child.C].isVisited && labyrinth[child.R, child.C].isPassable)
                {
                    sum += MaxSumPower(labyrinth, labyrinth[child.R, child.C]);
                }
                else
                {
                    return 0;
                }
            }

            return sum;
        }

        private static void CalculateChildAddresses(Cell[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    var current = labyrinth[i, j];

                    if (current.Address.R + current.Value < labyrinth.GetLength(0)
                    && labyrinth[current.Address.R + current.Value, current.Address.C].isPassable)
                    {
                        current.ChildAddresses.Add(new Address(current.Address.R + current.Value, current.Address.C));
                    }

                    if (current.Address.R - current.Value >= 0
                        && labyrinth[current.Address.R - current.Value, current.Address.C].isPassable)
                    {
                        current.ChildAddresses.Add(new Address(current.Address.R - current.Value, current.Address.C));
                    }

                    if (current.Address.C + current.Value < labyrinth.GetLength(1)
                        && labyrinth[current.Address.R, current.Address.C + current.Value].isPassable)
                    {
                        current.ChildAddresses.Add(new Address(current.Address.R, current.Address.C + current.Value));
                    }

                    if (current.Address.C - current.Value >= 0
                        && labyrinth[current.Address.R, current.Address.C - current.Value].isPassable)
                    {
                        current.ChildAddresses.Add(new Address(current.Address.R, current.Address.C - current.Value));
                    }
                }
            }
        }

        private static void MockInput()
        {
            string sampleInput = @"0 0
5 6
1 # 5 4 6 4
3 2 # 2 6 2
9 1 7 6 3 1 
8 2 7 3 8 6
3 6 1 3 1 2";

            var reader = new StreamReader(sampleInput);

            //while (line == null)
            //{
            //    line = reader.ReadLine();
            //}

            Console.SetIn(reader);
        }
    }

    public class Cell
    {
        public Cell(Address address, bool passable, int value, bool visited)
        {
            this.Address = address;
            this.isPassable = passable;
            this.Value = value;
            this.isVisited = visited;
            this.ChildAddresses = new List<Address>();
        }

        public Address Address { get; set; }

        public int Value { get; set; }

        public bool isVisited { get; set; }

        public bool isPassable { get; set; }

        public List<Address> ChildAddresses { get; set; }
    }

    public class Address
    {
        public Address(int row, int col)
        {
            this.R = row;
            this.C = col;
        }

        public int R { get; set; }

        public int C { get; set; }
    }
}

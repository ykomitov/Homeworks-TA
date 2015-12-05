namespace ActualExam_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Program1
    {
        public static void Main()
        {
            var game = new Game();

            string command = "";

            while (command != "end")
            {
                command = Console.ReadLine();
                game.ParseCommand(command);
            }
        }
    }

    public class Game
    {
        private const string AddUnitSuccess = "SUCCESS: {0} added!";
        private const string AddUnitFail = "FAIL: {0} already exists!";
        private const string RemoveUnitSuccess = "SUCCESS: {0} removed!";
        private const string RemoveUnitFail = "FAIL: {0} could not be found!";

        private HashSet<string> unitNames;
        private HashSet<Unit> unitList;
        private MultiDictionary<string, Unit> unitsByType;
        private Dictionary<int, List<Unit>> unitsByAttack;

        public Game()
        {
            this.unitNames = new HashSet<string>();
            this.unitList = new HashSet<Unit>();
            this.unitsByType = new MultiDictionary<string, Unit>(true);
            this.unitsByAttack = new Dictionary<int, List<Unit>>();
        }

        public void ParseCommand(string command)
        {
            var commandArr = command.Split(' ');

            switch (commandArr[0])
            {
                case ("add"):
                    var unitName = commandArr[1];
                    var unitType = commandArr[2];
                    var unitAttack = int.Parse(commandArr[3]);

                    var currentUnit = new Unit(unitName, unitType, unitAttack);

                    if (this.unitNames.Contains(unitName))
                    {
                        Console.WriteLine(AddUnitFail, unitName);
                        break;
                    }
                    else
                    {

                        this.unitNames.Add(unitName);
                        this.unitList.Add(currentUnit);

                        if (this.unitsByType.ContainsKey(unitType))
                        {
                            this.unitsByType[unitType].Add(currentUnit);
                        }
                        else
                        {
                            this.unitsByType[unitType] = new SortedSet<Unit>();
                            this.unitsByType[unitType].Add(currentUnit);
                        }

                        if (this.unitsByAttack.ContainsKey(unitAttack))
                        {
                            this.unitsByAttack[unitAttack].Add(currentUnit);
                        }
                        else
                        {
                            this.unitsByAttack[unitAttack] = new List<Unit>();
                            this.unitsByAttack[unitAttack].Add(currentUnit);
                        }

                        Console.WriteLine(AddUnitSuccess, unitName);
                    }

                    break;
                case ("remove"):
                    var unitNameToRemove = commandArr[1];


                    var foundUnit = this.unitList.Where(u => u.Name == unitNameToRemove).FirstOrDefault();

                    if (foundUnit == null)
                    {
                        Console.WriteLine(RemoveUnitFail, unitNameToRemove);
                        break;
                    }
                    else
                    {
                        this.unitNames.Remove(unitNameToRemove);
                        this.unitList.Remove(foundUnit);

                        this.unitsByAttack[foundUnit.Attack].Remove(foundUnit);

                        this.unitsByType[foundUnit.Type].Remove(foundUnit);

                        Console.WriteLine(RemoveUnitSuccess, unitNameToRemove);
                    }

                    break;
                case ("find"):
                    var unitTypeToFind = commandArr[1];

                    if (!this.unitsByType.ContainsKey(unitTypeToFind))
                    {
                        Console.WriteLine("RESULT: ");
                        break;
                    }
                    else
                    {
                        var unitsFound = this.unitsByType[unitTypeToFind]
                                .OrderByDescending(u => u.Attack)
                                .ThenBy(u => u.Name)
                                .Take(10)
                                .ToList();

                        PrintUnits(unitsFound);
                    }

                    break;
                case ("power"):
                    int numberOfUnits = int.Parse(commandArr[1]);

                    var list = this.unitsByAttack.Keys.ToList();
                    list.Sort();

                    var index = list.Count - 1;
                    var topList = new List<Unit>();
                    while (topList.Count < numberOfUnits && index >= 0)
                    {
                        var tempList = this.unitsByAttack[list[index]];
                        topList.AddRange(tempList);
                        index--;
                    }

                    var topPower = topList
                                .OrderByDescending(u => u.Attack)
                                .ThenBy(u => u.Name)
                                .Take(numberOfUnits)
                                .ToList();


                    PrintUnits(topPower);
                    break;
                default: break;
            }
        }

        private void PrintUnits(List<Unit> unitsFound)
        {
            if (unitsFound.Count == 0)
            {
                Console.WriteLine("RESULT: ");
            }
            else
            {
                var sb = new StringBuilder();

                for (int i = 0; i < unitsFound.Count; i++)
                {
                    sb.Append(unitsFound[i].Name);
                    sb.Append("[");
                    sb.Append(unitsFound[i].Type);
                    sb.Append("]");
                    sb.Append("(");
                    sb.Append(unitsFound[i].Attack);
                    sb.Append(")");

                    if (i < unitsFound.Count - 1)
                    {
                        sb.Append(", ");
                    }
                }

                Console.WriteLine("RESULT: {0}", sb.ToString());
            }
        }
    }

    public class Unit : IComparable<Unit>
    {
        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }

        public int CompareTo(Unit other)
        {
            return other.Attack.CompareTo(this.Attack);
        }
    }
}
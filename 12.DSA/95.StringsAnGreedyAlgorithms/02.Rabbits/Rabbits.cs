namespace _02.Rabbits
{
    using System;
    using System.Collections.Generic;

    public class Rabbits
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine().Split(' ');
            var rabbitAnswers = new Dictionary<int, int>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == "-1")
                {
                    break;
                }

                var currentInput = int.Parse(inputArr[i]);
                if (rabbitAnswers.ContainsKey(currentInput))
                {
                    rabbitAnswers[currentInput]++;
                }
                else
                {
                    rabbitAnswers[currentInput] = 1;
                }
            }

            long result = 0;
            foreach (var item in rabbitAnswers)
            {
                var currentValue = item.Value;
                var multiplier = 1;

                if (item.Key != 0)
                {
                    if (currentValue == 1)
                    {
                        result += item.Key + 1;
                    }
                    else if (currentValue % (item.Key + 1) != 0)
                    {
                        multiplier = (currentValue / (item.Key + 1)) + 1;
                        result += (item.Key + 1) * multiplier;
                    }
                    else
                    {
                        multiplier = currentValue / (item.Key + 1);
                        result += (item.Key + 1) * multiplier;
                    }
                }
                else
                {
                    result += item.Value;
                }
            }

            Console.WriteLine(result);
        }
    }
}

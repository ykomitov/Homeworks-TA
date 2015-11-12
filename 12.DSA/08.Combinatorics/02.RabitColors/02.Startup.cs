/*Задача 2 – Цветни зайци

Котаракът Стиви посетил града на зайците и попитал няколко от тях следния въпрос: „Ако не броиш себе си, колко зайци с еднакъв на твоя цвят, живеят в града?“. Всеки от попитаните зайци казал истината като бил попитан само веднъж от котарака. 
*/
namespace _02.RabitColors
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var rabbitAnswers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var currentInput = int.Parse(Console.ReadLine());
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

/*Задача 3 – Делители

Дадена е редица цифри. Създайте цяло число, като използвате всеки елемент на редицата точно по един път. Ако една и съща цифра присъства няколко пъти в редицата, то тя трябва да бъде използвана точно толкова пъти. Намерете числото с най-малък брой делители. За делител се броят не само простите числа. Ако има няколко числа с еднакъв брой делители и всички те отговарят на предното условие, то намерете най-малкото от тях. Цифрата „0“ може да бъде използвана за водеща в числата например 06 е числото 6 (за повече яснота вижте втория пример).
*/

namespace _03.Dividors
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static List<int> resultingNumbers = new List<int>();

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[] digits = new int[n];

            for (int i = 0; i < n; i++)
            {
                digits[i] = int.Parse(Console.ReadLine());
            }

            PermuteRep(digits, 0, n);

            var minDividor = int.MaxValue;
            List<int> numbers = new List<int>();

            foreach (var number in resultingNumbers)
            {
                // Count the number of divisors
                var tempDividor = 1;
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        tempDividor++;
                    }
                }

                // Check the current number's divisor count agains the minimum
                // If new minimum is found reinitialize the numbers list and add the current number 
                if (tempDividor < minDividor)
                {
                    numbers = new List<int>();
                    minDividor = tempDividor;
                    numbers.Add(number);
                }

                // If there is another number with the same number of divisors, just add the current number to the results list
                if (tempDividor == minDividor)
                {
                    numbers.Add(number);
                }
            }

            // Find the minimal number in the list
            var minNumber = numbers[0];
            foreach (var num in numbers)
            {
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }

            Console.WriteLine(minNumber);
        }

        private static void PermuteRep(int[] arr, int start, int n)
        {
            // Print(arr);
            resultingNumbers.Add(int.Parse(string.Join(string.Empty, arr)));

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[n - 1] = firstElement;
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}

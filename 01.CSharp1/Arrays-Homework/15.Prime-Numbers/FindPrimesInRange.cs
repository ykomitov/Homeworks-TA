/*	Write a program that finds all prime numbers in the range [`1...10 000 000`]. Use the [Sieve of Eratosthenes](http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) algorithm.*/

/*Number of primes from 2 to N:
 *      N               Primes count:
    	10          	4 	 
     	100 	        25 	 
     	1,000       	168 	 
     	10,000      	1,229 	 
     	100,000 	    9,592 	 
     	1,000,000 	    78,498 	 
     	10,000,000 	    664,579 	 
     	100,000,000 	5,761,455 	 
     	1,000,000,000 	50,847,534 	 
     	10,000,000,000 	455,052,511*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

class FindPrimesInRange
{
    static void Main()
    {
        //Start a stopwatch to see how long does the program run
        Stopwatch sw = new Stopwatch();
        sw.Start();

        int end = 10000000;
        int remove = int.MinValue;
        int[] allNums = new int[end];

        //Populate the allNums array with numbers from 1 to 10 000 000
        for (int i = 0; i < end; i++)
        {
            allNums[i] = i + 1;
        }

        //Replace 1
        allNums[0] = int.MinValue;

        //Replace all numbers but the primes
        for (int i = 1; i < end - 1; i++)
        {
            if (allNums[i] * allNums[i] > end)
            {
                break;
            }

            for (int j = allNums[i] * allNums[i] - 1; j < end; j++)
            {
                if (allNums[i] != int.MinValue)
                {
                    if (allNums[j] % allNums[i] == 0)
                    {
                        allNums[j] = remove;
                    }
                }
            }
        }

        //Create the sieve with the prime numbers
        List<int> sieve = new List<int>();
        for (int i = 0; i < allNums.Length; i++)
        {
            if (allNums[i] != int.MinValue)
            {
                sieve.Add(allNums[i]);
            }
        }

        //Count the number of primes & print it to the console
        int primes = sieve.Count;
        Console.WriteLine("From 1 to {0}, there are {1} prime numbers.", end, primes);

        //Stop the stopwatch
        sw.Stop();
        TimeSpan elapsedTime = sw.Elapsed;
        Console.WriteLine(elapsedTime);
    }
}

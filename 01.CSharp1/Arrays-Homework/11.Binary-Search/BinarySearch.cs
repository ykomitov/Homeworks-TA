//	Write a program that finds the index of given element in a sorted array of integers by using the [Binary search](http://en.wikipedia.org/wiki/Binary_search_algorithm) algorithm.

/*In computer science, a binary search or half-interval search algorithm finds the position of a specified input value (the search "key") within an array sorted by key value. For binary search, the array should be arranged in ascending or descending order. In each step, the algorithm compares the search key value with the key value of the middle element of the array. If the keys match, then a matching element has been found and its index, or position, is returned. Otherwise, if the search key is less than the middle element's key, then the algorithm repeats its action on the sub-array to the left of the middle element or, if the search key is greater, on the sub-array to the right. If the remaining array to be searched is empty, then the key cannot be found in the array and a special "not found" indication is returned.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        //String input contains randomly generated integers from 0 to 1000
        string input = "536,921,906,115,680,292,509,742,220,761,437,368,211,372,546,549,318,798,687,783,405,407,723,871,676,521,273,275,704,568,502,728,598,446,384,954,663,431,489,733,405,298,38,84,882,787,122,326,190,133,608,390,968,516,666,843,978,637,400,966,493,249,308,604,755,251,143,796,346,597,91,393,535,146,157,65,586,692,923,835,956,799,637,714,744,913,842,693,240,166,153,202,834,553,820,172,167,540,918,431,239,286,579,298,944,177,426,731,858,574,925,42,34,511,936,719,546,66,176,289,242,560,819,815,167,575,854,963,529,458,361,324,150,936,295,412,954,951,787,138,776,585,521,53,774,68,418,512,843,329,796,507,927,445,729,571,601,565,724,649,774,40,484,949,363,403,190,991,787,533,348,226,830,821,106,406,842,593,827,781,529,865,327,382,720,450,896,268,388,574,122,296,14,467,965,427,404,281,914,225,292,963,500,387,291,227,841,90,647,883,44,413,955,463,672,549,816,474,297,616,705,192,420,99,556,510,902,5,156,649,712,383,451,619,156,980,523,566,919,756,611,601,473,617,153,423,435,804,219,915,990,901,244,688,440,627,257,217,682,831,689,168,25,995,903,16,308,748,880,236,777,145,271,923,587,22,107,8,333,226,435,109,386,722,884,170,300,692,255,803,150,199,803,976,571,867,130,499,672,515,30,538,977,169,948,977,538,990,859,479,493,580,592,778,389,54,977,796,5,688,148,79,620,676,618,314,594,141,34,777,821,307,138,8,682,233,646,570,60,841,871,416,49,730,989,139,405,297,861,407,95,973,668,326,367,723,62,595,846,626,896,674,520,901,508,160,802,693,259,126,63,927,606,897,4,365,227,878,891,766,159,346,774,31,496,389,263,16,601,782,6,889,196,570,791,50,68,502,479,713,944,284,994,937,676,717,938,717,65,178,975,322,356,96,146,563,444,956,460,564,52,943,591,244,465,800,203,471,626,609,9,941,55,17,663,152,191,29,698,681,858,173,456,46,300,201,947,197,780,858,58,688,721,20,254,11,984,703,264,928,186,214,434,270,494,979,565,927,506,927,564,429,42,409,350,30,100,697,966,484,957,430,410,579,488,932,960,821,44,605,842,16,776,603,842,781,192,546,974,499,506,814,209,728,43,153,783,588,592,22,8,85,157,734,43,948,469,674,619,426,792,623,827,62,395,319,243,711,904,500,743,416,891,111,708,806,746,224,588,299,784,240,128,121,220,780,299,992,676,38,613,893,249,902,421,347,218,24,801,592,315,434,634,534,652,912,289,34,207,145,942,58,735,922,615,200,574,489,219,178,141,763,90,862,234,260,572,597,126,544,239,841,234,880,904,257,938,19,476,465,696,650,861,21,254,99,714,789,756,310,832,185,288,483,659,746,20,535,359,484,331,216,183,630,264,573,917,545,728,990,841,706,659,663,828,660,376,353,243,800,80,252,615,153,626,384,578,293,383,521,582,913,461,226,396,528,540,701,650,94,955,991,993,747,648,702,109,618,272,210,787,21,280,310,481,377,396,357,658,119,61,972,205,487,527,833,106,981,676,642,950,172,843,66,867,715,739,522,210,897,904,986,957,55,721,695,720,83,691,927,131,213,940,274,505,1,534,381,798,537,732,657,578,683,278,150,463,106,503,74,279,578,902,239,892,206,148,301,718,387,103,753,121,486,268,894,278,829,410,778,555,545,201,765,149,924,394,748,595,835,433,165,15,574,691,527,393,287,381,446,768,319,641,718,871,583,109,444,191,460,343,712,494,835,107,404,14,69,907,807,954,31,567,953,297,640,907,101,286,381,260,435,480,959,355,837,323,384,78,754,382,915,635,735,793,440,963,395,228,254,657,450,204";

        //<------- Some tests for your convinience ;) ------->

        int key = 4;        //Index of 4 in the array is 1.
        //int key = 994;    //Index of 994 in the array is 821.
        //int key = 995;    //Index of 995 in the array is 822.
        //int key = 520;    //Index of 520 in the array is 411.
        //int key = 1;      //Index of 1 in the array is 0.
        //int key = 2;      //Not found!

        //Split the string into an integer array
        int[] inputArray = input.Replace(" ", string.Empty).Split(',').Select(n => Int32.Parse(n)).ToArray();

        //Sort the array in ascending order
        Array.Sort(inputArray);

        //Some variables to work with - to store the middle index, the end index and the index of the key (if found);
        int indexMiddle = inputArray.Length / 2;
        int indexEnd = inputArray.Length;
        int indexKey = int.MinValue;

        while (true)
        {
            //If the key is found in the array, get the index and break the loop
            if (key == inputArray[indexMiddle])
            {
                indexKey = indexMiddle;
                break;
            }

            //If the key is not found in the array, break the loop
            else if (indexMiddle == 0)
            {
                break;
            }

            //Cases where key is less than or higher than the middle elements 
            else if (key < inputArray[indexMiddle])
            {
                indexEnd = indexMiddle;
                indexMiddle = indexEnd / 2;
                continue;
            }

            else if (key > inputArray[indexMiddle])
            {
                indexMiddle = indexMiddle + (((indexEnd - indexMiddle) / 2));
                continue;
            }
        }

        //Print the result on the console
        if (indexKey == int.MinValue)
        {
            Console.WriteLine("Not found!");
        }
        else
        {
            Console.WriteLine("Index of {0} in the array is {1}.", key, indexKey);
        }
    }
}

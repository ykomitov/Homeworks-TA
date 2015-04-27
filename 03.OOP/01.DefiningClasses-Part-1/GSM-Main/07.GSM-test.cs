/*### Problem 7. GSM test
*	Write a class `GSMTest` to test the `GSM` class:
	*	Create an array of few instances of the `GSM` class.
	*	Display the information about the GSMs in the array.
	*	Display the information about the static property `IPhone4S`.*/

using System;
using System.Collections.Generic;


namespace MobilePhone
{
    class GSMTest
    {
        static void Main()
        {
            var gsmList = new List<GSM>();
            gsmList.Add(new GSM("nokia", "3310"));
            gsmList.Add(new GSM("lg", "G2", 500.42M));
            gsmList.Add(new GSM("siemens", "C100", 23.45M, "Grisha", "Ganchev"));

            var theIPhone = new GSM(" ", " ");
            theIPhone = theIPhone.IPhone4S;

            for (int i = 0; i < gsmList.Count; i++)
            {
                Console.WriteLine(gsmList[i]);
            }
            Console.WriteLine(theIPhone);
        }
    }
}
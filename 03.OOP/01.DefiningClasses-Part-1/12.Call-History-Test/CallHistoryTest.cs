/*### Problem 12. Call history test
*	Write a class `GSMCallHistoryTest` to test the call history functionality of the `GSM` class.
	*OK*	Create an instance of the `GSM` class.
	*OK*	Add few calls.
	*OK*	Display the information about the calls.
 	*OK*	Assuming that the price per minute is `0.37` calculate and print the total price of the calls in the history.
	*OK*	Remove the longest call from the history and calculate the total price again.
	*OK*	Finally clear the call history and print it.*/

using System;

namespace MobilePhone
{
    class CallHistoryTest
    {
        static void Main()
        {
            //create a test instance & add 3 calls
            var gsmTest = new GSM("nokia", "test model");
            gsmTest.AddCall(new Call(new DateTime(2015, 12, 31, 10, 00, 00), "0888123456", 61));
            gsmTest.AddCall(new Call(new DateTime(2016, 12, 31, 10, 15, 00), "0888666555", 333));
            gsmTest.AddCall(new Call(new DateTime(2017, 01, 01, 00, 00, 01), "0888123456", 60));


            //test call price calculations
            Console.WriteLine("Test call price calculation method\r\n==========================================");
            Console.WriteLine("Total Calls Count: {0}", gsmTest.CallHistory.Count);
            Console.WriteLine("Total Price: {0: 0.00}", gsmTest.CallPrice(0.37M));
            Console.WriteLine();

            //print initial state of the instance
            Console.WriteLine("Initial state of the gsmTest object\r\n==========================================\r\n{0}", gsmTest);

            //delete the longest call
            int indexLongestCall = -1;
            int maxSeconds = 0;
            foreach (var call in gsmTest.CallHistory)
            {
                if (call.Duration > maxSeconds)
                {
                    maxSeconds = (int)call.Duration;
                    indexLongestCall++;
                }
            }
            gsmTest.DeleteCall(indexLongestCall);

            //print price without longest call
            Console.WriteLine("\r\nPrice calculation without the longest call\r\n==========================================");
            Console.WriteLine("Total Calls Count: {0}", gsmTest.CallHistory.Count);
            Console.WriteLine("Total Price: {0: 0.00}\r\n", gsmTest.CallPrice(0.37M));
            Console.WriteLine("gsmTest object without the longest call\r\n==========================================\r\n{0}", gsmTest);

            //print the final state of the instance

            //clear the history
            gsmTest.ClearHistory();

            Console.WriteLine("gsmTest object with cleared history\r\n==========================================\r\n{0}", gsmTest);
        }
    }
}

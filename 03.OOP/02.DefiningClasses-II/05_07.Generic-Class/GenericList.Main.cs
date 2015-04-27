namespace GenericList
{
    using System;

    class TestGenericList
    {
        static void Main()
        {
            /*### Problem 5. Generic class
             * Write a generic class `GenericList<T>` that keeps a list of elements of some parametric type `T`.
             * Keep the elements of the list in an array with fixed capacity which is given as parameter
             * Implement methods for:
                * adding element
                * accessing element by index
                * removing element by index
                * inserting element at given position
                * clearing the list
                * finding element by its value
                * override `ToString()`.
             * Check all input parameters to avoid accessing elements at invalid positions.*/

            //Create a generic list of strings with lenght of 3
            GenericList<string> testList = new GenericList<string>(3);

            //adding elements
            Console.WriteLine("<========== Adding Elements =========>");
            testList.AddElement("1");
            testList.AddElement("2");
            testList.AddElement(" ^");
            Console.WriteLine(testList); //ToString is overwritten!
            Console.WriteLine();

            //remove element at index 2
            Console.WriteLine("<========== Removing Element at Index 2 =========>");
            testList.RemoveElement(2);
            Console.WriteLine(testList);
            Console.WriteLine();

            //insert element
            Console.WriteLine("<========== Insert Element at Index 0 =========>");
            testList.InsertElement("666", 0);
            Console.WriteLine(testList);
            Console.WriteLine();

            //access element at given position
            Console.WriteLine("<========== Access Element at Index 1 =========>");
            Console.WriteLine(testList[1]);
            Console.WriteLine();

            //find element
            Console.WriteLine("<========== Search for Element =========>");
            Console.WriteLine(testList.FindElement("3"));
            Console.WriteLine(testList.FindElement("666"));
            Console.WriteLine();

            //clear the contents of the generic list
            Console.WriteLine("<========== Clear the List =========>");
            Console.WriteLine("\r\nAttempting to clear the generic list.");
            testList.ClearAll();
            Console.WriteLine(testList);

            /*### Problem 6. Auto-grow
             * Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.*/


            Console.WriteLine("<========== Testing the Auto-Grow =========>");
            GenericList<double> testList2 = new GenericList<double>(5);
            
            //create a list with 5 members from 1 to 5;
            for (int i = 1; i <= 5; i++)
            {
                testList2.AddElement(i);
            }
            Console.WriteLine("Initial state of the list:");
            Console.WriteLine(testList2);

            Console.WriteLine("\r\n6 values added...");
            testList2.AddElement(3.14d);
            testList2.AddElement(99);
            testList2.AddElement(98);
            testList2.AddElement(97);
            testList2.AddElement(96);
            testList2.AddElement(95);

            Console.WriteLine("\r\nThe list was increased:");
            Console.WriteLine(testList2);

            /*### Problem 7. Min and Max
             * Create generic methods `Min<T>()` & `Max<T>()` for finding the minimal and maximal elements
             * You may need to add a generic constraints for the type `T`.*/


            Console.WriteLine("\r\n<========== Testing Min & Max =========>");
            Console.WriteLine("Minimal element is {0}", testList2.Min());
            Console.WriteLine("Maximal element is {0}", testList2.Max());
            Console.WriteLine();
        }
    }
}
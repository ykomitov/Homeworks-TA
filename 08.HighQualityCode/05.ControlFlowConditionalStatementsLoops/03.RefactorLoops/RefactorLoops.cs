namespace _03.RefactorLoops
{
    using System;

    public class RefactorLoops
    {
        public static void Main(string[] args)
        {
            var array = new int[] { 3, 40, 5, 6, 1, 1, 1, 1, 1, 1, 41 };
            var expectedValue = 40;
            bool isFound = false;

            // Refactor the following loop
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    isFound = true;
                    break;
                }
            }

            // More code here
            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

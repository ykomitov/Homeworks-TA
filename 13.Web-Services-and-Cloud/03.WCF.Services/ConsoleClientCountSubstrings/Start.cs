namespace ConsoleClientCountSubstrings
{
    using System;

    public class Start
    {
        public static void Main()
        {
            // If the service is not running, the following code will throw exception. Run the service from the project HostCountSubstring
            var service = new CountSubstringsServiceClient(); // Using the auto-generated code!

            var subString = "test";
            var originalString = "testtesttest";
            var count = service.CountSubstringRepetitionsWithinString(subString, originalString);
            Console.WriteLine("Substring \"{0}\" is contained within \"{1}\" {2} times.", subString, originalString, count);
            Console.ReadLine();
        }
    }
}

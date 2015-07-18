namespace Methods
{
    using System;

    class MethodsTest
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.DigitToText(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintFormattedNumber(1.3, "f");
            Methods.PrintFormattedNumber(0.75, "%");
            Methods.PrintFormattedNumber(2.30, "r");

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Is horizontal? " + Methods.IsHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Is vertical? " + Methods.IsVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", Birthday = new DateTime(1992, 3, 17) };
            peter.OtherInfo = "From Sofia";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", Birthday = new DateTime(1993, 11, 3) };
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

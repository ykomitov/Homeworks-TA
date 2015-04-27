namespace BitArray64
{
    using System;

    class BitArrayTest
    {
        static void Main()
        {
            var test = new BitArray64(18);
            var test1 = new BitArray64(18);
            int extractedBit = test[59];


            Console.WriteLine("Original input > test : {0}", test.BitValues);
            Console.WriteLine("Original input > test1: {0}", test1.BitValues);
            Console.WriteLine("test ? test1 >>> {0}", test.Equals(test1));
            Console.WriteLine("GetHast test : {0}", test.GetHashCode());
            Console.WriteLine("GetHast test1: {0}", test1.GetHashCode());
            Console.WriteLine("Testing == and != operators");
            Console.WriteLine(test == test1);
            Console.WriteLine(test != test1);
            Console.WriteLine("Changing bit at position 1 in test array to 1");
            test[1] = 1;
            Console.WriteLine(test.BitValues);
            Console.WriteLine("Changing bit at position 1 back to 0");
            test[1] = 0;
            Console.WriteLine(test.BitValues);

        }
    }
}

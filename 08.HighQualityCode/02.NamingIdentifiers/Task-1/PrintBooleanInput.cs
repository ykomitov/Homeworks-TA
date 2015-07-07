namespace Task_1
{
    using System;

    public class PrintBooleanInput
    {
        public const int MaxCount = 6;

        public static void EntryPoint()
        {
            PrintBooleanInput.PrintInput boolPrinter = new PrintBooleanInput.PrintInput();
            boolPrinter.PrintBoolean(true);
        }

        public class PrintInput
        {
            public void PrintBoolean(bool boolInput)
            {
                string boolInputAsString = boolInput.ToString();
                Console.WriteLine(boolInputAsString);
            }
        }
    }
}

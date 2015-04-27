using System;
using System.IO;

class Garden
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\SampleInput.txt");
        //Console.SetIn(reader);


        decimal tomatoPrice = 0.5M;
        decimal cucumberPrice = 0.4M;
        decimal potatoPrice = 0.25M;
        decimal carrotPrice = 0.6M;
        decimal cabbagePrice = 0.3M;
        decimal beansPrice = 0.4M;
        int availableArea = 250;

        int tomatoAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberAmount = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());

        int potatoAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());

        int carrotAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beansAmount = int.Parse(Console.ReadLine());

        decimal totalPrice =
            tomatoAmount * tomatoPrice +
            cucumberAmount * cucumberPrice +
            potatoAmount * potatoPrice +
            carrotAmount * carrotPrice +
            cabbageAmount * cabbagePrice +
            beansAmount * beansPrice;

        Console.WriteLine("Total costs: {0:0.00}", totalPrice);

        int usedArea = tomatoArea+cucumberArea+potatoArea+carrotArea+cabbageArea;
        if (usedArea == availableArea)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            if (usedArea > availableArea)
            {
                Console.WriteLine("Insufficient area");
            }
            else
            {
                Console.WriteLine("Beans area: {0}", availableArea-usedArea);
            }
        }
    }
}

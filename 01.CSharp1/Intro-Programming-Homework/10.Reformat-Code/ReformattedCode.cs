using System;

/*Reformat the following C# code to make it readable according to the C# best practices for code formatting. Change the casing of the identifiers in the code (e.g. use PascalCase for the class name): HorribleCode.cs
 
using

System;

class hoRRiblEcoDe
{
	static
	 void

		Main()
	{
		Console.

	WriteLine("Hi, I am horribly formatted program"
); Console.
	  WriteLine("Numbers and squares:")
; for (int i = 0;
i < 10;
i++)
		{
			Console.WriteLine(i +
				" --> " + i
				*
				i);
		}
	}
}
 */
class ReformattedCode
{
    static void Main()
    {
        Console.WriteLine("Hi, I am a well formatted program now ;-)\r\n");
        Console.WriteLine("Numbers and squares:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + " --> " + i * i);
        }

    }
}
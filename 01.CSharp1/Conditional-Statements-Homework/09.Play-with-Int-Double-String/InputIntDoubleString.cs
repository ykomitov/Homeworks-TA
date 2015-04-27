using System;

/*	Write a program that, depending on the user's choice, inputs an `int`, `double` or `string` variable.
	*	If the variable is `int` or `double`, the program increases it by one.
	*	If the variable is a `string`, the program appends `*` at the end.
    *	Print the result at the console. Use switch statement.

_Example 1:_

| program                | user  |
|------------------------|-------|
| Please choose a type:  |       |
| 1 --> int              |       |
| 2 --> double           | 3     |
| 3 --> string           |       |
|                        |       |
| Please enter a string: | hello |
|                        |       |
| hello*                 |       |

_Example 2:_

| program                | user |
|------------------------|------|
| Please choose a type:  |      |
| 1 --> int              |      |
| 2 --> double           | 2    |
| 3 --> string           |      |
|                        |      |
| Please enter a double: | 1.5  |
|                        |      |
| 2.5                    |      |*/

class InputIntDoubleString
{
    static void Main()
    {
        int choice;
        int a;
        double b;
        string c;
        bool choiceCheck;
        bool tryParse;

        do
        {
            Console.WriteLine("Please choose a type:\r\n1 --> int\r\n2 --> double\r\n3 --> string");
            tryParse = int.TryParse(Console.ReadLine(), out choice);
            choiceCheck = choice == 1 || choice == 2 || choice == 3;
            if (choiceCheck == false)
            {
                Console.WriteLine("Invalid input\r\n");
            }
        } while (choiceCheck == false);

        if (choice == 1)
        {
            do
            {
                Console.Write("Please enter an integer: ");
                tryParse = int.TryParse(Console.ReadLine(), out a);
                if (tryParse == false)
                {
                    Console.WriteLine("Invalid input\r\n");
                }
                else
                {
                    a = a + 1;
                    Console.WriteLine(a);
                }
            } while (tryParse == false);
        }

        if (choice == 2)
        {
            do
            {
                Console.Write("Please enter a double: ");
                tryParse = double.TryParse(Console.ReadLine(), out b);
                if (tryParse == false)
                {
                    Console.WriteLine("Invalid input\r\n");
                }
                else
                {
                    b = b + 1;
                    Console.WriteLine(b);
                }
            } while (tryParse == false);
        }

        if (choice == 3)
        {
            Console.Write("Please enter a string: ");
            c = Console.ReadLine();
            Console.WriteLine("{0}*", c);
        }
    }
}
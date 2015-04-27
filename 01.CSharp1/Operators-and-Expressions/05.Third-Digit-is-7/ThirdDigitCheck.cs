using System;

/*Write an expression that checks for given integer if its third digit from right-to-left is `7`.
|    n    | Third digit 7? |
|:-------:|:--------------:|
| 5       | false          |
| 701     | true           |
| 9703    | true           |
| 877     | false          |
| 777877  | false          |
| 9999799 | true           |*/

class ThirdDigitCheck
{
    static void Main()
    {
        Console.Write("Please intup an integer: ");
        int input = int.Parse(Console.ReadLine());
        bool test = Math.Abs((input / 100) % 10) == 7 ;
        Console.WriteLine("Third digit from right-to-left = 7? " + test);
    }
}

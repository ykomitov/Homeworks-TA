using System;

/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by `7` and `5` at the same time.

_Examples:_

|  n  | Divided by 7 and 5? |
|:---:|:-------------------:|
| 3   | false               |
| 0   | false               |
| 5   | false               |
| 7   | false               |
| 35  | true                |
| 140 | true                |*/
class DivisionCheck
{
    static void Main()
    {
        Console.Write("Please intup an integer: ");
        int input = int.Parse(Console.ReadLine());
        bool test = input != 0 && input % 7 == 0 && input % 5 == 0;
        Console.WriteLine(test);
    }
}

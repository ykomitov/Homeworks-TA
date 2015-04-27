using System;

/*	Write a program that applies bonus score to given score in the range `[1-9]` by the following rules:
	*	If the score is between `1` and `3`, the program multiplies it by `10`.
	*	If the score is between `4` and `6`, the program multiplies it by `100`.
	*	If the score is between `7` and `9`, the program multiplies it by `1000`.
	*	If the score is `0` or more than `9`, the program prints `invalid score`.
 
 * _Examples:_

| score | result        |
|-------|---------------|
| 2     | 20            |
| 4     | 400           |
| 9     | 9000          |
| -1    | invalid score |
| 10    | invalid score |*/

class BonusScore
{
    static void Main()
    {
        int score;

        do
        {
            Console.Write("Please enter score in the range [1-9]: ");
            score = int.Parse(Console.ReadLine());

            if (score < 1 || score > 9)
            {
                Console.WriteLine("Invalid score!\r\n");
            }
        }
        while (score < 1 || score > 9);

        if (score > 0 && score < 4)
        {
            score = score * 10;
        }
        if (score > 3 && score < 7)
        {
            score = score * 100;
        }
        if (score > 6 && score < 10)
        {
            score = score * 1000;
        }

        Console.WriteLine("Final score is " + score);
    }
}
using System;

class Secret
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int specialSum = 0;
        int number = n;
        int position = 1;
        while (number > 0)
        {
            int digit = number % 10;
            number /= 10;
            if (position % 2 == 0)
            {
                specialSum += digit * digit * position;
            }
            else
            {
                specialSum += digit * position * position;
            }
            int sequenceLenght = specialSum % 10;
            if (sequenceLenght == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", n);
            }
            else
            {
                int start = specialSum % 26;
                //0-25
                //'A' до 'Z'
                Console.WriteLine((char)('A'+5));
            }
            position++;
        }
    }
}
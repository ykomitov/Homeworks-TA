namespace _03.Precision
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int maxDenominator = int.Parse(Console.ReadLine());
            var fraction = Console.ReadLine().Split('.')[1];

            int bestNom = 0;
            int bestDenom = 1;
            int precision = 0;
            for (int den = 1; den <= maxDenominator; den++)
            {
                int left = 0;
                int right = den;

                while (left < right)
                {
                    int middle = (left + right) / 2;

                    if (Compare(fraction, middle, den))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                int current = Divide(fraction, left - 1, den);
                if (current > precision)
                {
                    bestDenom = den;
                    bestNom = left - 1;
                    precision = current;
                }

                current = Divide(fraction, left, den);
                if (current > precision)
                {
                    bestDenom = den;
                    bestNom = left;
                    precision = current;
                }

            }

            Console.WriteLine("{0}/{1}", bestNom, bestDenom);
            Console.WriteLine(precision + 1);
        }

        private static int Divide(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit != fraction[i] - '0')
                {
                    break;
                }
                a = a % b * 10;
            }
            return i;
        }

        private static bool Compare(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit < fraction[i] - '0')
                {
                    return false;
                }
                else if (digit > fraction[i] - '0')
                {
                    return true;
                }

                a = a % b * 10;
            }
            return true;
        }
    }
}


//public class Startup
//{
//    public static void Main()
//    {
//        int maxDenominator = int.Parse(Console.ReadLine());
//        var fraction = Console.ReadLine().Split('.')[1];

//        int bestNom = 0;
//        int bestDenom = 1;
//        int precision = 1;
//        for (int den = 1; den < maxDenominator; den++)
//        {
//            for (int nom = 0; nom < den; nom++)
//            {
//                int currentPrecision = Divide(fraction, nom, den);

//                if (currentPrecision > precision)
//                {
//                    bestNom = nom;
//                    bestDenom = den;
//                    precision = currentPrecision;
//                }
//            }
//        }
//        Console.WriteLine("{0}/{1}", bestNom, bestDenom);
//        Console.WriteLine(precision + 1);
//    }

//    private static int Divide(string fraction, int a, int b)
//    {
//        a *= 10;
//        int i;
//        for (i = 0; i < fraction.Length; i++)
//        {
//            int digit = a / b;
//            if (digit != fraction[i] - '0')
//            {
//                break;
//            }
//            a = a % b * 10;
//        }
//        return i;
//    }
//}
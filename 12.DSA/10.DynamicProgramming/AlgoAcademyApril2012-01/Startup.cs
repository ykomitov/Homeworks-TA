/*Редица на Трибоначи наричаме такава последователност от числа, при която всяко следващо число се образува като сума на предните три елемента от редицата:
 
Напишете програма, която намира N-тия елемент от редицата на Трибоначи по дадени N и първите три елемента от редицата. Математически казано: по зададени Т1, Т2 и T3, намерете TN.
Вход
Входните данни се четат от стандартния вход (конзолата).
На първия и единствен ред на конзолата ще бъдат дадени последователно числата T1, T2, T3 и N, разделени с точно 1 интервал.
Входните данни ще са винаги валидни и в описания формат.
Изход
Изходните данните трябва да се изведат на стандартния изход (конзолата).
На единствения ред на стандартния изход трябва да изведете N-тия елемент от зададената редица на Тибоначи.
*/
namespace AlgoAcademyApril2012_01
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputAsArr = input.Split(' ').Select(long.Parse).ToArray();

            long[] output = new long[inputAsArr[3]];
            output[0] = inputAsArr[0];
            output[1] = inputAsArr[1];
            output[2] = inputAsArr[2];

            for (int i = 3; i < output.Length; i++)
            {
                output[i] = output[i - 1] + output[i - 2] + output[i - 3];
            }

            Console.WriteLine(output[output.Length - 1]);
        }
    }
}

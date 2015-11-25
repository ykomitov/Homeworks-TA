/*СуперСума е функция, която се дефинира като:
 СуперСума(0, N) = N, за всяко положително цяло число N.
 СуперСума(K, N) = СуперСума(К - 1, 1) + СуперСума(K - 1, 2) + … + СуперСума(K - 1, N), за всяко положително цяло число K и N.
Напишете програма, която по зададени K и N, връща резултата от извикването на СуперСума(K, N).
Вход
Входните данни се четат от стандартния вход (конзолата).
На първия ред от входа се намират числата K и N, разделени с точно един интервал.
Входните данни ще са винаги валидни и в описания формат.
Изход
Изходните данните трябва да се изведат на стандартния изход (конзолата).
На единствения ред на стандартния изход трябва да изведете стойността на СуперСума(K, N)
*/

namespace AlgoAcademyApril2012_02
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            ////var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ////var inputArr = new int [] { 1, 3 };
            var inputArr = new int[] { 2, 3 };

            var ss = SuperSum(inputArr[0], inputArr[1]);

            Console.WriteLine(ss);
        }

        public static long SuperSum(int k, int n)
        {
            if (k == 0)
            {
                return n;
            }

            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += SuperSum(k - 1, i);
            }

            return sum;
        }
    }
}

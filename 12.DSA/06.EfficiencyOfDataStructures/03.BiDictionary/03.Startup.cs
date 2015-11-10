/*Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} and fast search by key1, key2 or by both key1 and key2.

    Note: multiple values can be stored for given key.
*/

namespace _03.BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            var testBiDictionary = new BiDictionary<int, double, string>();

            testBiDictionary.Add(1, 1, "Pesho");
            testBiDictionary.Add(1, 1, "Gosho");
            testBiDictionary.Add(1, 2, "Stamat");
            testBiDictionary.Add(2, 14, "Penko");
            testBiDictionary.Add(2, 3, "Haralampi");

            var testFindByKey1 = testBiDictionary.Find(2);
            var testFindByKey2 = testBiDictionary.Find(1d);
            var testFindByTwoKeys = testBiDictionary.Find(2, 3d);

            Console.WriteLine("Results from first search: {0}", string.Join(", ", testFindByKey1));
            Console.WriteLine("Results from second search: {0}", string.Join(", ", testFindByKey2));
            Console.WriteLine("Results from third search: {0}", string.Join(", ", testFindByTwoKeys));

            testBiDictionary.Remove(2, 14, "Penko");
            var expectedNull = testBiDictionary.Find(2, 14);

            if (expectedNull == null)
            {
                Console.WriteLine("Remove successfull!");
            }
        }
    }
}

/*A large trade company has millions of articles, each described by barcode, vendor, title and price.

    Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y].
    Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET.
*/

namespace _02.FastRetrivalByOrderedMutiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public const int NumberOfProducts = 1000000; // On my rather old & dusty laptop, 1 million articles take ~ 9 seconds
        public const int NumberOfArticlesToPrint = 10;

        public static void Main()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(false);

            DateTime start_at = DateTime.Now;
            for (int i = 0; i < NumberOfProducts; i++)
            {
                var tempArticle = new Article(
                                                RandomGenerator.GetRandomBarcode(13),
                                                RandomGenerator.GetRandomStringWithRandomLength(5, 10),
                                                RandomGenerator.GetRandomStringWithRandomLength(10, 15),
                                                RandomGenerator.GetRandomDecimalBetween(5, 15));

                articles.Add(tempArticle.Price, tempArticle);
            }

            DateTime stop_at = DateTime.Now;
            Console.WriteLine("{0} articles generated in {1} secs", NumberOfProducts, new TimeSpan(stop_at.Ticks - start_at.Ticks).TotalSeconds);

            var retrievedArticles = articles.Range(10, true, 10.5M, true);

            Console.WriteLine("Articles in range: {0}", retrievedArticles.Count);
            Console.WriteLine("Top {0} articles: ", NumberOfArticlesToPrint);

            foreach (var article in retrievedArticles.ToList().Take(NumberOfArticlesToPrint))
            {
                Console.WriteLine(article);
            }
        }
    }
}

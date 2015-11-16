namespace CountSubstringsWithinString
{
    public class CountSubstringsService : ICountSubstringsService
    {
        public int GountSubstringRepetitionsWithinString(string substring, string originalString)
        {
            int count = 0;
            int startIndex = 0;
            string tempString = originalString;

            while (true)
            {
                string searchString = tempString.Substring(startIndex);
                startIndex = searchString.IndexOf(substring);
                tempString = searchString;

                if (startIndex != -1)
                {
                    count++;
                    startIndex++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}

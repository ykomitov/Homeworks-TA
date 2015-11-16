namespace CountSubstringsWithinString
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ICountSubstringsService
    {
        [OperationContract]
        int CountSubstringRepetitionsWithinString(string substring, string originalString);
    }
}

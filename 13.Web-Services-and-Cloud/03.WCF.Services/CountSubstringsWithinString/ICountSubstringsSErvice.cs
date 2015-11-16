namespace CountSubstringsWithinString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    [ServiceContract]
    public interface ICountSubstringsService
    {
        [OperationContract]
        int GountSubstringRepetitionsWithinString(string substring, string originalString);
    }
}

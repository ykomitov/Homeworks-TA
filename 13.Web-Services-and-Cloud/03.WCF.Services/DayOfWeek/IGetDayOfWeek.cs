namespace DayOfWeek
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IGetDayOfWeek
    {
        [OperationContract]
        string GetDayOfWeekUsingService(DateTime date);
    }
}

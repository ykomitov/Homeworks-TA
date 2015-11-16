namespace DayOfWeek
{
    using System;

    public class GetDayOfWeekService : IGetDayOfWeek
    {
        public string GetDayOfWeekUsingService(DateTime date)
        {
            var day = date.DayOfWeek;
            string result;

            switch (day)
            {
                case DayOfWeek.Monday:
                    result = "понеделник";
                    break;
                case DayOfWeek.Tuesday:
                    result = "вторник";
                    break;
                case DayOfWeek.Wednesday:
                    result = "сряда";
                    break;
                case DayOfWeek.Thursday:
                    result = "четвъртък";
                    break;
                case DayOfWeek.Friday:
                    result = "петък";
                    break;
                case DayOfWeek.Saturday:
                    result = "събота";
                    break;
                case DayOfWeek.Sunday:
                    result = "неделя";
                    break;
                default:
                    result = "You is dead! Не би трябвало да се стигне тук!";
                    break;
            }

            return result;
        }
    }
}

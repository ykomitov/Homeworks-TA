namespace _01.Students_and_courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private const int maxAllowedID = 99999;
        private static int lastUsedID = 9999;

        public static int GetUniqueStudentID()
        {
            lastUsedID = lastUsedID + 1;

            if (lastUsedID > maxAllowedID)
            {
                throw new Exception("Maximum number of students in the school is reached! Cannot add another student!");
            }

            return lastUsedID;
        }
    }
}

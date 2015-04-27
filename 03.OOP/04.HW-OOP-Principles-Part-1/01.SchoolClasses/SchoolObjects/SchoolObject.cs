namespace School
{
    using System;
    using System.Linq;

    abstract class SchoolObject
    {
        private string comment;

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set 
            {
                this.comment = value; 
            }
        }
    }
}

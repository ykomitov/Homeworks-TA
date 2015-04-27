namespace RangeExceptions
{
    using System;
    using System.Linq;

    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end, string msg)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(T start, T end, string msg, Exception innerEx)
            : base(msg, innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }
    }
}

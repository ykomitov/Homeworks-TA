using System;

namespace MobilePhone
{
    public class Call
    {
        //fields
        private DateTime dateTime;
        private string phoneNum;
        private uint duration;

        //constructors
        public Call(DateTime dateTime, string phone, uint duration)
        {
            this.Date = dateTime;
            this.PhoneNum = phone;
            this.Duration = duration;
        }

        //properties
        public DateTime Date
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string PhoneNum
        {
            get
            {
                return this.phoneNum;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number cannot be null or empty!");
                }

                string test = value;
                bool isValidPhone = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsDigit(test[i]))
                    {
                        continue;
                    }
                    else
                    {
                        isValidPhone = false;
                        break;
                    }
                }

                if (!isValidPhone)
                {
                    throw new ArgumentException("Phone number can only contain numeric characters!");
                }

                this.phoneNum = value;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value could not be <= 0");
                }
                this.duration = value;
            }
        }
    }
}

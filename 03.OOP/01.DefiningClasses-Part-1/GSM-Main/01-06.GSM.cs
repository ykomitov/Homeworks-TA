using System;
using System.Collections.Generic;

namespace MobilePhone
{
    public class GSM
    {
        //fields
        private string manufacturer;
        private string model;
        private decimal? price;
        private string ownerName;
        private string ownerSurname;
        private Battery battery;
        private Display display;

        //=== Problem 9 ==> Add a property `CallHistory` in the `GSM` class to hold a list of the performed calls.
        private List<Call> callHistory = new List<Call>();

        //=== Problem 6 ==> Add a static field and a property `IPhone4S` in the GSM class to hold the information about iPhone 4S.
        private static GSM iPhone4S = new GSM("Apple", "iPhone 4S", 5.00M, "Gosho", "Peshov");

        //=== Problem 2 ==> Constructors
        /*  Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        *	Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.*/
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = null;
            this.OwnerName = null;
            this.OwnerSurname = null;
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public GSM(string manufacturer, string model, decimal? price)
            : this(manufacturer, model)
        {
            this.Price = price;
            this.OwnerName = null;
            this.OwnerSurname = null;
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public GSM(string manufacturer, string model, decimal? price, string ownerName, string ownerSurname)
            : this(manufacturer, model, price)
        {
            this.OwnerName = ownerName;
            this.OwnerSurname = ownerSurname;
            this.Battery = new Battery();
            this.Display = new Display();
        }

        //=== Problem 5 ==> Properties
        /**	Use properties to encapsulate the data fields inside the `GSM`, `Battery` and `Display` classes.
        *	Ensure all fields hold correct data at any given time.*/

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
                this.manufacturer = UppercaseWords(value);
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
                this.model = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price could not be <= 0");
                }
                this.price = value;
            }
        }

        public string OwnerName
        {
            get { return this.ownerName; }
            set { this.ownerName = UppercaseWords(value); }
        }

        public string OwnerSurname
        {
            get { return this.ownerSurname; }
            set { this.ownerSurname = UppercaseWords(value); }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        //=== Problem 4 ==>  Add a method in the GSM class for displaying all information about it. Override ToString().

        public override string ToString()
        {
            string output = string.Format(
            "Mobile phone: {0}\r\nModel: {1}\r\nPrice: {2}\r\nOwner: {3} {4}\r\nBattery: {5} {6} {7} {8}\r\nDisplay size: {9}\r\nDisplay colors: {10}", this.Manufacturer, this.Model, this.Price, this.OwnerName, this.OwnerSurname, this.Battery.Type, this.Battery.BatteryModel, this.Battery.HoursIdle, this.Battery.HoursTalk, this.Display.Size, this.Display.Colors);

            if (this.CallHistory.Count > 0)
            {
                output+= "\r\n\r\nCall History:";

                int counter = 1;
                foreach (var call in CallHistory)
                {
                    output += string.Format("\r\n{0}. Date: {1}, Phone Num: {2}, Call Duration: {3}", counter, call.Date, call.PhoneNum, call.Duration);
                    ++counter;
                }
            }
            Console.WriteLine();
            return output;
        }

        //=== Problem 10 ==> Add methods in the `GSM` class for adding and deleting calls from the calls history. Add a method to clear the call history.
        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(int indexOfCall)
        {
            callHistory.RemoveAt(indexOfCall);
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        //=== Method for correcting lowercase first letters
        public string UppercaseWords(string value)
        {
            if (value == null)
            {
                return "";
            }
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        //=== Problem 11 ==> Call price
        /*	Add a method that calculates the total price of the calls in the call history.
        *	Assume the price per minute is fixed and is provided as a parameter.*/
        public decimal CallPrice(decimal pricePerMinute)
        {
            uint totalCallsInSeconds = 0;

            foreach (var call in CallHistory)
            {
                totalCallsInSeconds += call.Duration;
            }

            decimal totalPrice = ((decimal)totalCallsInSeconds / 60) * pricePerMinute;
            return totalPrice;
        }
    }

    public class Battery : Enumerations
    {
        private string batteryModel;
        private BatteryType? type;
        private double? hoursIdle;
        private double? hoursTalk;

        //constructors
        public Battery()
        {
            this.batteryModel = null;
            this.type = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        //properties
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.BatteryModel = value; }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value could not be <= 0");
                }
                this.HoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value could not be <= 0");
                }
                this.HoursTalk = value;
            }
        }

        public BatteryType? Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }

    public class Display
    {
        private double? size;
        private uint? numberOfColors;

        //constructor
        public Display()
        {
            this.size = null;
            this.numberOfColors = null;
        }

        public Display(double? size, uint? numberOfColors)
        {
            this.Size = size;
            this.Colors = numberOfColors;
        }

        //properties
        public double? Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value could not be <= 0");
                }
                this.size = value;
            }
        }

        public uint? Colors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value could not be <= 0");
                }
                this.numberOfColors = value;
            }
        }
    }
}
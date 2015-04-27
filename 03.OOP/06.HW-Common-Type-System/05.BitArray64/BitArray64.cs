namespace BitArray64
{
    //*	Define a class `BitArray64` to hold `64` bit values inside an `ulong` value.
    //Implement `IEnumerable<int>` and `Equals()`, `GetHashCode()`, `[]`, `==` and `!=`.

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong bitValues;

        public BitArray64(ulong bitArrAsUlong)
        {
            this.BitValues = bitArrAsUlong;
        }

        public ulong BitValues
        {
            get
            {
                return this.bitValues;
            }
            set
            {
                if (value < 0 || value > ulong.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Value entered is outside of the valid range for a 64 unsigned integer!");
                }
                this.bitValues = value;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int this[int index]
        {
            get
            {
                var bitArr = new int[64];
                string bitArrString = Convert.ToString((long)this.BitValues, 2).PadLeft(64, '0');
                for (int i = 0; i < 64; i++)
                {
                    bitArr[i] = bitArrString[i] - '0';
                }

                return bitArr[index];
            }

            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Invalid index position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new IndexOutOfRangeException("Bit value can only be 1 or 0!");
                }

                var bitArr = new int[64];
                string bitArrString = Convert.ToString((long)this.BitValues, 2).PadLeft(64, '0');
                for (int i = 0; i < 64; i++)
                {
                    bitArr[i] = bitArrString[i] - '0';
                }

                bitArr[index] = value;
                string newNum = String.Join("", bitArr);
                this.BitValues = Convert.ToUInt64(newNum, 2);
            }
        }

        public override bool Equals(object other64BitArr)
        {
            return this.BitValues.Equals((other64BitArr as BitArray64).BitValues);
        }

        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return (arr1.Equals(arr2));
        }

        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1.Equals(arr2));
        }

        public override int GetHashCode()
        {
            return 23 * this.BitValues.GetHashCode();
        }
    }
}
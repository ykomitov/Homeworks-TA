/*### Problem 5. Generic class
* 
*	Write a generic class `GenericList<T>` that keeps a list of elements of some parametric type `T`.
*	Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
*	Implement methods for 
     *	OK    adding element
     *	OK    accessing element by index
     *	OK    removing element by index
     *	OK    inserting element at given position
     *	OK    clearing the list
     *	OK    finding element by its value
     *	OK    ToString()
*	Check all input parameters to avoid accessing elements at invalid positions.*/

namespace GenericList
{
    using System;
    using System.Text;

    class GenericList<T> where T : IComparable<T>
    {
        private T[] genericList;
        private int usedPlaces;

        public GenericList(int capacity)
        {
            this.genericList = new T[capacity];
            this.usedPlaces = 0;
        }

        public void AddElement(T element)
        {
            if (this.usedPlaces == this.genericList.Length)
            {
                this.Grow();
                this.genericList[this.usedPlaces] = element;
            }
            else
            {
                this.genericList[this.usedPlaces] = element;
            }
            this.usedPlaces++;
        }

        public void RemoveElement(int position)
        {
            if (position < 0 || position >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("Invalid position entered!");
            }

            for (int i = position; i < this.usedPlaces - 1; i++)
            {
                this.genericList[i] = this.genericList[i + 1];
            }
            this.genericList[this.usedPlaces - 1] = default(T);
            usedPlaces--;
        }

        public void InsertElement(T element, int position)
        {
            if (position < 0 || position >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("Invalid position entered!");
            }
            this.genericList[position] = element;
        }

        public void ClearAll()
        {
            for (int i = 0; i < this.usedPlaces; i++)
            {
                this.genericList[i] = default(T);
            }
            usedPlaces = 0;
            Console.WriteLine("List is cleared...");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.usedPlaces; i++)
            {
                sb.Append(this.genericList[i]);
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.usedPlaces)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = genericList[index];
                return result;
            }
            set
            {
                this.genericList[index] = value;
            }
        }

        public string FindElement(T element)
        {
            for (int i = 0; i < genericList.Length; i++)
            {
                if (element.CompareTo(this.genericList[i]) == 0)
                {
                    return string.Format("Element {1} found at index {0}.", i, element);
                }
            }
            return string.Format("Element {0} not found!", element);
        }

        /*Problem 7. Min and Max
          Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.*/
        public T Min()
        {
            T min = default(T);
            for (int i = 0; i < this.usedPlaces; i++)
            {
                if (i == 0)
                {
                    min = this.genericList[i];
                }
                if (min.CompareTo(this.genericList[i]) > 0)
                {
                    min = this.genericList[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = default(T);
            for (int i = 0; i < this.usedPlaces; i++)
            {
                if (i == 0)
                {
                    max = this.genericList[i];
                }
                if (max.CompareTo(this.genericList[i]) < 0)
                {
                    max = this.genericList[i];
                }
            }
            return max;

        }

        /*  Problem 6. Auto-grow
         *  Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.*/
        private void Grow()
        {
            int doubleSize = this.genericList.Length * 2;
            T[] doubleGenList = new T[doubleSize];

            for (int i = 0; i < this.genericList.Length; i++)
            {
                doubleGenList[i] = this.genericList[i];
            }
            this.genericList = doubleGenList;
        }
    }
}
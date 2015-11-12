namespace SortingHomework
{
    using System.Collections.Generic;

    public static class HelperMethods
    {
        public static void Swap<T>(IList<T> arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

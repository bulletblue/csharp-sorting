using System;

namespace Practice
{
    class Search
    {
        /// <summary>
        /// Performs a binary search to locate the index of a given argument in an array.
        /// </summary>
        /// <param name="searchItem">The item to search for.</param>
        /// <param name="arr">The array which will be searched through.</param>
        /// <param name="start">The start index at which to perform search.</param>
        /// <param name="end">The end index at which to perform search.</param>
        /// <returns>Index of the searchItem in arr if located, or -1 if the item is not found.</returns>
        public static int binarySearch(int searchItem, int[] arr, int start, int end)
        {
            // We've exceeded the array on the right side and searchItem has not been found.
            if (start > end)
            {
                return -1;
            }
            // Both are pointing to the same item, or there are no items in the array.
            else if (end == start)
            {
                return (arr[end] == searchItem) ? 0 : -1;
            }
            // Otherwise, we perform a recursive binary search.
            else
            {
                int mid = (end - start + 1) / 2 + start;
                int index = -1;

                // Midpoint landed on the searchItem, so we return it.
                if (arr[mid] == searchItem) return mid;
                // searchItem may only be located to the LEFT of the midpoint.
                else if (arr[mid] > searchItem) index = binarySearch(searchItem, arr, start, mid - 1);

                // searchItem may only be located to the RIGHT of the midpoint.
                else index = binarySearch(searchItem, arr, mid + 1, end);

                return index;
            }
        }
    }
}

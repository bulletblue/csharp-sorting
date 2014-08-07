using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Search
    {
        public static int binarySearch(int searchItem, int[] arr, int start, int end)
        {
            if (arr.Length == 0) return -1;
            else if (arr.Length == 1)  return (arr[0] == searchItem) ? 0 : -1;
            else
            {
                int mid = (end - start + 1) / 2 + start;
                int index = -1;

                if (arr[mid] == searchItem) return mid;
                else if (start == end) return -1;
                else if (arr[mid] > searchItem) index = binarySearch(searchItem, arr, start, mid - 1);
                else index = binarySearch(searchItem, arr, mid + 1, end);

                return index;
            }
        }
    }
}

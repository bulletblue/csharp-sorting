using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 6, 8, 11, 12, 13, 14, 20, 22, 27 };

            // Uncomment below to test quickSort and specify unsorted array above
            //Sort.quickSort(ref arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
            Console.WriteLine();

            // Binary Search
            Console.WriteLine("The number {0} is at index {1}.", 11, Search.binarySearch(11, arr, 0, arr.Length - 1));
        }

    }
}

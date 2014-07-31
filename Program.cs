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
            int[] intArray = new int[3]; // { 0, 58, 36, 81, 27, 34 };
            Random r = new Random();

            Console.WriteLine("Original:");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = r.Next(100);
                Console.Write(intArray[i] + " ");
                if (i == intArray.Length - 1) Console.WriteLine("");
            }
            
            Console.WriteLine();
            //Sort.slowSort(ref intArray, 0);
            //Sort.quickSort(ref intArray, 0, intArray.Length - 1);
            //Sort.mergeSort();

            Console.WriteLine("New:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
                if (i == intArray.Length - 1) Console.WriteLine("");
            }
            Console.WriteLine();
        }

    }
}

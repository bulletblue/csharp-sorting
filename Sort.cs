using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Sort
    {
        public static void slowSort(ref int[] arr, int startIndex)
        {
            if (startIndex != arr.Length)
            {
                int minIndex = startIndex;

                for (int i = startIndex + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[startIndex])
                        swap(ref arr, i, minIndex);
                }

                slowSort(ref arr, startIndex + 1);
            }
        }

        public static int[] mergeSort(ref int[] arr, int start, int end)
        {
            if (arr.Length == 0) return null;
            else if (arr.Length == 1) return new int[] {arr[1]};
            else
            {
                int midpoint = (end + 1) / 2;
                int[] left = null, right = null;
                int[] sortedArray = new int[end + 1];

                if ((end + 1) % 2 == 0) //even
                {
                    left = mergeSort(ref arr, 0, midpoint - 1);
                    right = mergeSort(ref arr, midpoint, end);
                }
                else //odd
                {
                    left = mergeSort(ref arr, 0, midpoint);
                    right = mergeSort(ref arr, midpoint + 1, end);
                }





                return null;
            }
        }

        public static void quickSort(ref int[] arr, int wall, int pivot)
        {
            if (pivot <= 0 || (pivot - wall) <= 0) // || wall >= arr.Length
            {
                return;
            }
            else
            {
                int originalWall = wall;

                for (int i = wall; i < pivot; i++)
                {       
                    if (arr[i] < arr[pivot])
                    {
                        swap(ref arr, i, wall);
                        wall = wall + 1;
                    }
                }

                swap(ref arr, pivot, wall);

                quickSort(ref arr, originalWall, wall - 1); //left side
                quickSort(ref arr, wall + 1, pivot); //right side
            }
        }

        static private void swap(ref int[] arr, int index1, int index2)
        {
            int tmp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = tmp;
        }
    }
}

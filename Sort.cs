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
            else if (arr.Length == 1) return new int[] {arr[0]};
            else if (start == end) return new int[] {arr[end]};
            else
            {
                int midpoint = ((end - start + 1) / 2) + start;
                int[] left = null, right = null;
                int[] sortedArray = new int[end - start + 1];

                if ((end + 1) % 2 == 0) //even
                {
                    left = mergeSort(ref arr, start, midpoint - 1);
                    right = mergeSort(ref arr, midpoint, end);
                }
                else //odd
                {
                    left = mergeSort(ref arr, 0, midpoint);
                    right = mergeSort(ref arr, midpoint + 1, end);
                }

                //for (int i = 0; i < left.Length; i++) Console.Write(left[i] + " ");
                //Console.Write("     ");
                //for (int i = 0; i < right.Length; i++) Console.Write(right[i] + " ");
                //Console.WriteLine();

                int sortedIndex, leftIndex, rightIndex;
                sortedIndex = leftIndex = rightIndex = 0;

                while (sortedIndex < sortedArray.Length)
                {
                    if (leftIndex < left.Length && rightIndex < right.Length)
                    {
                        if (left[leftIndex] < right[rightIndex])
                        {
                            sortedArray[sortedIndex] = left[leftIndex];
                            sortedIndex++;
                            leftIndex++;
                        }
                        else if (right[rightIndex] < left[leftIndex])
                        {
                            sortedArray[sortedIndex] = right[rightIndex];
                            sortedIndex++;
                            rightIndex++;
                        }
                        else
                        {
                            sortedArray[sortedIndex] = left[leftIndex];
                            sortedIndex++;
                            sortedArray[sortedIndex] = right[rightIndex];
                            sortedIndex++;
                            leftIndex++;
                            rightIndex++;
                        }
                    }
                    else if (leftIndex < left.Length) //right array is used up
                    {
                        sortedArray[sortedIndex] = left[leftIndex];
                        sortedIndex++;
                        leftIndex++;
                    }
                    else if (rightIndex < right.Length) //left array is used up
                    {
                        sortedArray[sortedIndex] = right[rightIndex];
                        sortedIndex++;
                        rightIndex++;
                    }
                }

                return sortedArray;
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

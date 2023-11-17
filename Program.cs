using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_BinarySearchNdBubbleSort
{
    internal class Program
    {

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int noswap = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                        noswap++;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        // Function for Binary Search in a sorted array
        static int BinarySearch(int[] arr, int sitem)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == sitem)
                {
                    return mid;
                }
                if (arr[mid] < sitem)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1; // Key not found
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        //To check array is sorted Correctly
        public static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] arr = { 15, 23, 4, 19, 60, 7 };
            Console.WriteLine("print array without sort");
            Print(arr);
            BubbleSort(arr);
            Console.WriteLine("after bubble sort in descending order:");
            Print(arr);
            bool isSorted = IsSorted(arr);
            Console.WriteLine($"Is sorted array correctly? {isSorted}");

            // Binary Search demonstration

            Console.WriteLine("enter item to search using binary search");
            int sItem = int.Parse(Console.ReadLine());
            int result = BinarySearch(arr, sItem);
            if (result != -1)
            {
                Console.WriteLine($"Element {sItem} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Element {sItem} not found in the array");
            }
            Console.ReadKey();

        }
    }
}


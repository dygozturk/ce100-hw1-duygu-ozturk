using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs

{
    public class Class1
    {
        /**
         * Function to sort array
         * 
         */
        /**
         * @name InsertionSort (Insertion Sort)
         * @brief InsertionSort
         * Insertion Sort
         * @param [in] unsortedList [\b double] unsortedList
         * */

        public static int InsertionSort(int[] arr)
        {
            int t = arr.Length;
            for (int l = 1; l < t; l++)
            {
                int key = arr[l];
                int s = l - 1;
                //! change elements of arr that from the biggest than key to other position 
                while (s >= 0 && arr[s] > key)
                {
                    arr[s + 1] = arr[s];
                    s = s - 1;
                }
                arr[s + 1] = key;
            }
            return arr.Length;
        }
        /**
        * Function to sort array
        * 
        */
        /**
    *
    *	  @name   SelectionSort (Selection Sort)
    *
    *	  @brief Selection Sort
    *
    *	  Selection Sort
    *
    *	  @param  [in] unsortedList [\b double]  unsortedList
    *	  
    *	  
    *	  
    **/
        public static int SelectionSort(int[] arr)
        {
            int n = arr.Length;
            // One by one move boundary of unsorted subarray
            for (int l = 0; l < n - 1; l++)
            {
                //! Find the minimum element in unsorted array
                int mind_idx = l;
                for (int s = l + 1; s < n; s++)
                {
                    if (arr[s] < arr[mind_idx])
                    {
                        mind_idx = s;
                    }
                }
                //! to change found min item with first item
                int temp = arr[mind_idx];
                arr[mind_idx] = arr[l];
                arr[l] = temp;
            }
            return arr.Length;
        }

        /** A utility function to print
        *array of size n
        **/
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int l = 0; l < n; ++l)
            {
                Console.Write(arr[l] + " ");
            }
            Console.Write("\n");
        }
        /**
        * Function to recursive merge sort
        * 
        */
        /**
        *
        *	  @name   mergeSort (Merge Sort)
        *
        *	  @brief Merge Sort
        *
        *	  Merge Sort
        *
        *	  @param  [in] array [\b int]  array
        *	  
        *	  
        *	  
        **/


        public static int MergeSort(int[] array, int d, int o)
        {
            if (d < o)
            {
                int q = d + (o - d) / 2;
                MergeSort(array, d, q);
                MergeSort(array, q + 1, o);
                MergeSort(array, d, q, o);
            }
            return array.Length;
        }
        /**
        * Function to merge sort
        * 
        */
        public static void MergeSort(int[] data, int t, int r, int b)
        {
            int l, s, k;
            //! Find sizes of two
            //! subarrays to be merged
            int n1 = r - t + 1;
            int n2 = b - r;

            //!to create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];

            // to write data to temp arrays
            for (l = 0; l < n1; l++)
            {
                L[l] = data[t + l];
            }
            for (s = 0; s < n2; s++)
            {
                R[s] = data[r + 1 + s];
            }
            l = 0; s = 0; k = t;

            //! first items of array merged
            while (l < n1 && s < n2)
            {
                if (L[l] <= R[s])
                {
                    data[k] = L[l];
                    l++;
                }
                else
                {
                    data[k] = R[s];
                    s++;
                }
                k++;
            }
            //! to write remaining elements
            //! of L[]
            while (l < n1)
            {
                data[k] = L[l];
                l++;
                k++;
            }
            //! to write remaining elements
            //! of R[]
            while (s < n2)
            {
                data[k] = R[s];
                s++;
                k++;
            }
        }
        /**
        * Function to calculate power of number with iterative version
        * 
        */
        /**
        *
        *	  @name   NaivePower (Naive Power)
        *
        *	  @brief Naive Power
        *
        *	  Naive Power
        *
        *	  @param  [in] number [\b int]  number
        *	  
        *	  @param  [in] power [\b int]  power
        *	  
        *	  
        **/
        public static long NaivePower(int x, int n)
        {
            long pow = 1L;  //!to initialize result by 1
            for (int l = 0; l < n; l++)  //!multiply "x" exactly "n" times
            {
                pow = pow * x;
            }
            return pow;
        }
        /**
        * Function to calculate power of number with recursive version
        * 
        */
        /**
        *
        *	  @name   RecursivePower (Recursive Power)
        *
        *	  @brief Recursive Power
        *
        *	  Recursive Power
        *
        *	  @param  [in] n [\b int]  n
        *	  
        *	  @param  [in] p [\b int]  p
        *	  
        *	  
        **/
        public static long RecursivePower(int z, int n)
        {
            if (n != 0)
            {
                return (z * RecursivePower(z, n - 1));
            }
            return 1;
        }
        /**
        * Function to search item in array
        * 
        */
        /**
        *
        *	  @name   BinarySearchIterative (Binary Search Iterative)
        *
        *	  @brief Binary Search Iterative
        *
        *	  Binary Search Iterative
        *
        *	  @param  [in] inputArray [\b int]  inputArray
        *	  
        *	  @param  [in] key [\b int]  key
        *	  
        *	  
        **/
        public static int IterativeBinarySearch(int[] arr, int y)
        {
            int d = 0, r = arr.Length - 1;
            while (d <= r)
            {
                int s = d + (r - 1) / 2;

                // to control if x is present at mid
                if (arr[s] == y)
                {
                    return s;
                }
                // If x greater, ignore left half 
                if (arr[s] < y)
                {
                    d = s + 1;
                }
                //! If x is smaller, ignore right half
                else
                {
                    r = s - 1;
                }
            }
            //! to access here when element is not present in array
            return -1;
        }
        /**
        * Function to search item in array
        * 
        */
        /**
        *
        *	  @name   BinarySearchRecursive (Binary Search Recursive)
        *
        *	  @brief Binary Search Recursive
        *
        *	  Binary Search Recursive
        *
        *	  @param  [in] inputArray [\b int]  inputArray
        *	  
        *	  @param  [in] key [\b int]  key
        *	  
        *	  @param  [in] min [\b int]  min
        *	  
        *	  @param  [in] max [\b int]  max
        *	  
        *	  
        **/
        public static int RecursiveBinarySearch(int[] arr, int f, int k, int s)
        {
            if (k >= f)
            {
                int mid = f + (k - f) / 2;
                //! If the element is showed at the middle itself
                if (arr[mid] == s)
                {
                    return mid;
                }
                //!If item is smaller than mid, then it can only be present
                //! in left of array
                if (arr[mid] > s)
                {
                    return RecursiveBinarySearch(arr, f, k, s);
                }
                //! item can only be present in right subarray
                return RecursiveBinarySearch(arr, mid + 1, k, s);
            }
            //! to access here when element is not present in array
            return -1;
        }
        public static string MasterMethod(int manzara, Func<int, string> function)
        {
            return function(manzara);
        }
        // Call via:
        string result = MasterMethod(2, a =>
        {
            if (a == 1)
            {
                return "if";
            }
            else
            {
                return "else";
            }
        });
    }

}

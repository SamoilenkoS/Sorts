using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public static class SortAlgorithms<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static void QuickSort(T[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        public static void MergeSort(T[] arr)
        {
            var newArr = MergeSort(arr.ToList()).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = newArr[i];
            }
        }

        private static List<T> MergeSort(List<T> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            var left = new List<T>();
            var right = new List<T>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().CompareTo(right.First()) <= 0)  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        private static void QuickSort(T[] arr, int a, int b)
        {
            if (a >= b)
            {
                return;
            }

            int c = Partition(arr, a, b);
            QuickSort(arr, a, c - 1);
            QuickSort(arr, c + 1, b);
        }

        private static int Partition(T[] arr, int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)
            {
                if (arr[j].CompareTo(arr[b]) <= 0)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }

            return i - 1;
        }

        private static void Swap(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }

    public static class Test
    {
        public static void TestMyArray(int[] arr)
        {
            arr[0] = -1;
        }
    }
}

using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bubbleSortInput = new int[] { 1, 5, 3, 10, 9, 15 };
            Console.Write("Unsorted array for Bubble sort: ");
            PrintArray(bubbleSortInput);
            BubbleSort(bubbleSortInput);
            Console.Write("After Bubble sort: ");
            PrintArray(bubbleSortInput);

            int[] selectionSortInput = new int[] { 1, 5, 3, 10, 9, 15 };
            Console.Write("Unsorted array for Selection sort: ");
            PrintArray(selectionSortInput);
            SelectionSort(selectionSortInput);
            Console.Write("After Selection sort: ");
            PrintArray(selectionSortInput);

            int[] insertionSortInput = new int[] { 1, 5, 3, 10, 9, 15 };
            Console.Write("Unsorted array for Insertion sort: ");
            PrintArray(insertionSortInput);
            SelectionSort(insertionSortInput);
            Console.Write("After Insertion sort: ");
            PrintArray(insertionSortInput);
        }
        #region BubbleSort implementation
        public static void BubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        exchange(data, i, i + 1);
                    }
                }
            }
        }
        #endregion

        #region Selection sort implementation
        public static void SelectionSort(int[] data)
        {
            int i;
            int N = data.Length;
            for (i = 0; i < N - 1; i++)
            {
                int k = GetArrayMin(data, i);
                if (i != k)
                {
                    exchange(data, i, k);
                }
            }
        }

        public static int GetArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
            {
                if (data[pos] < data[minPos])
                    minPos = pos;
            }
            return minPos;
        }
        #endregion

        #region Insertion sort implemention
        public static void InsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
        }
        #endregion

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;
            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public static void PrintArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + ", ");
            }
            Console.Write("\b\b ");
            Console.WriteLine();
        }
    }
}

using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] { 10, 20, 490, 4, 7, 40 };
            int[] output = SelectionSort(input);
            foreach (var item in output)
            {
                Console.WriteLine(item);

            }
        }

        static int[] SelectionSort(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < items[minIndex])
                    {
                        minIndex = j;
                    }

                }
                int ithValue = items[i];
                items[i] = items[minIndex];
                items[minIndex] = ithValue;
            }
            return items;
        }
    }
}

namespace SortingAlgorithms
{
    public static class QuickSort
    {

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partition = Partition(arr, low, high);

                // Recursively sort elements before
                // partition and after partition
                Sort(arr, low, partition - 1);
                Sort(arr, partition + 1, high);
            }
        }
    }
}

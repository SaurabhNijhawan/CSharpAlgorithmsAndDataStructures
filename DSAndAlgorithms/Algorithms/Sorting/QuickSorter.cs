namespace DSAndAlgorithms
{
    public static class QuickSorter
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(array, left, right);
                QuickSort(array, left, q - 1);
                QuickSort(array, q + 1, right);
            }
        }

        // Remember quicksort partition is a 8 step process
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];  // 1
            int i = left-1;  // 2

            for (int j = left; j < right; j++)  // 3
            {
                if (array[j] <= pivot)  // 4
                {
                    i++;  // 5
                    int temp = array[i];
                    array[i] = array[j]; // 6 swap i and j
                    array[j] = temp;
                }

            }

            int temp1 = array[right];
            array[right] = array[i+1]; // 7 swap right and i+1
            array[i+1] = temp1;

            return i + 1;  // 8
        }
    }
}
namespace DSAndAlgorithms.Algorithms.Sorting
{
    public static class MergeSorter
    {
        public static void MergeSort(int[] array)
        {
            AuxillaryMergeSort(array, 0, array.Length - 1);
        }

        private static void AuxillaryMergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int q = (start + end) / 2;
                AuxillaryMergeSort(array, start, q);
                AuxillaryMergeSort(array, q + 1, end);
                Merge(array, start, q, end);
            }
        }

        private static void Merge(int[] array, int left, int mid, int right)
        {
            var B = new int[right-left+1];
            int i, j, k;
            i = k = left;
            j = mid + 1;
            while (i <= mid && j <= right)
            {
                if (array[i] < array[j])
                {
                    B[k++] = array[i++];
                }
                else
                {
                    B[k++] = array[j++];
                }
            }
            while (i <= mid)
            {
                B[k++] = array[i++];
            }

            while (j <= right)
            {
                B[k++] = array[j++];
            }

            for (i = left; i <= right; i++)
            {
                array[i] = B[i];
            }
        }
    }
}
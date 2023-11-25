namespace algorithms.Classes
{
    internal static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                        Helpers.Swap(ref arr[i], ref arr[j]);
                }
            }
        }

        public static void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int indexOfMin = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[indexOfMin] > arr[j])
                        indexOfMin = j;
                }

                Helpers.Swap(ref arr[indexOfMin], ref arr[i]);
            }
        }

        public static void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && current < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }
        }

        public static void Merge(int[] arr)
            => Merge(arr, 0, arr.Length - 1);

        private static void Merge(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Merge(arr, left, middle);
                Merge(arr, middle + 1, right);

                MergeHelper(arr, left, middle, right);
            }
        }

        private static void MergeHelper(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];

            for (int i = 0; i < n2; i++)
                rightArr[i] = arr[middle + i + 1];

            int x = 0,
                y = 0,
                z = left;

            while (x < n1 && y < n2)
            {
                if (leftArr[x] <= rightArr[y])
                    arr[z++] = leftArr[x++];

                else
                    arr[z++] = rightArr[y++];
            }

            while (x < n1)
                arr[z++] = leftArr[x++];

            while (y < n2)
                arr[z++] = rightArr[y++];
        }
    }
}

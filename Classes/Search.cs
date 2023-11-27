namespace algorithms.Classes
{
    internal static class Search
    {
        public static int Linear(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1;
        }

        public static int Binary(int[] arr, int target, bool isSorted = false)
        {
            if (!isSorted)
                Array.Sort(arr);

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == target)
                    return middle;

                if (target > arr[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1;
        }
    }
}

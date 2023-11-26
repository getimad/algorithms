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
    }
}

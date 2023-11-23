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
    }
}

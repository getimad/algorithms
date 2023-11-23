namespace algorithms.Classes
{
    internal static class Helpers
    {
        public static void Swap(ref int num1, ref int num2)
            => (num1, num2) = (num2, num1);
    }
}

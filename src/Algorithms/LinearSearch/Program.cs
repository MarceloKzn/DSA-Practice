namespace Algorithms
{
    public static class LinearSearchAlgorithm
    {
        public static int LinearSearch(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0)
                return -1;

            int end = arr.Length;
            
            for(int i = 0; i <= end ; i++)
            {
                if(arr[i] == target) return i;
            }
            return -1;
        }
    }
}
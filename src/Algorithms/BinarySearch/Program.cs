namespace Algorithms
{
    public static class BinarySearchAlgorithm
    {
        public static int BinarySearch(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0)
                return -1;

            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (left - right) / 2;
                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target) 
                    left = mid + 1;
                else 
                    right = mid - 1;
            }
            return -1;
        }
    }
}
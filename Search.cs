public class Search
{
    public static int BinarySearch(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start)/2;
            if(target > arr[mid]) 
            {
                start = mid + 1;
            }
            else if(target < arr[mid])
            {
                end = mid - 1;
            }
            else
            {
                return mid;
            }
        }
         return -1;
    }   
}

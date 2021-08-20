public class Floor
{
    // floor means largest integer less than or equal to a given number
    public static int FloorOfNumber(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;
        if(target < arr[start]) return - 1;
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
         return arr[end];
    }   
}

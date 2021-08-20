public class Ceiling
{
    //The ceiling function of a real number is the least integer number greater than or equal to the given number. 
    public static int CeilingOfNumber(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;
        if(target > arr[end]) return - 1;
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
         return arr[start];
    }   
}

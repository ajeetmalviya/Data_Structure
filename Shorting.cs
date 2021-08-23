public class Shorting
{
 
 public static void SelectionShort(int[] arr)
 {
     for (int i = 0; i < arr.Length - 1; i++)
     {
         int last = arr.Length - i - 1;
         int maxIndex = GetMaxIndex(arr, 0, last);
         Swap(arr, maxIndex, last);
                  
     }
     System.Console.WriteLine(string.Join(',',  arr));
 }

    public static int GetMaxIndex(int[] arr, int start, int end)
    {
        int max = start;
        for (int i = start; i <= end; i++)
        {
            if(arr[max] < arr[i])
            {
                max = i;
            }
        }
        return max;
    }
    public static void Swap(int[] arr, int first, int second)
    {
        var temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }
}


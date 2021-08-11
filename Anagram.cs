using System;

public static class Anagram
{
    //using sort
    public static bool AreAnagram(string str1, string str2)
    {
        if(str1.Length != str2.Length) return false;
        var str1Chars = str1.ToCharArray();
        var str2Chars = str2.ToCharArray();
        Array.Sort(str1Chars);
        Array.Sort(str2Chars);
        if(new String(str1Chars) != new string(str2Chars)) return false;
        else return true;
    }

    // using char array

    public static bool AreAnagramUsingCount(string str1, string str2)
    {
        if(str1.Length != str2.Length) return false;
        var count1 = new int[256];
        var count2 = new int[256];

        for (int i = 0; i < str1.Length; i++)
        {
            count1[str1[i]]++;
            count2[str2[i]]++;
        }

         for (var i = 0; i < 256; i++)
         {
            if (count1[i] != count2[i]) return false;     
         }         
 
        return true;
    }
}
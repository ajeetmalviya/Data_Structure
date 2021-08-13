//reverse string

using System.Collections.Generic;

public class Reverse
{
    public static string ReverseString(string str1)
    {
        if(string.IsNullOrEmpty(str1)) return string.Empty;
        if(str1.Length == 1) return str1;
        string result = "";
        int len = str1.Length - 1;
        while(len >= 0)
        {
            result += str1[len];
            len--;
        }
        return result;       
    }

    /*Given a String S, reverse the string without reversing its individual words. Words are separated by dots.*/
    public static string ReverseWords(string line)
    {
        if(string.IsNullOrEmpty(line) ) return string.Empty;
        string result = string.Empty;
        var strArr = line.Split('.');
        if(strArr.Length == 1) return strArr[0];
        var index = strArr.Length - 1;
        while(index >= 0)
        {
            result += strArr[index--] + ".";
        }
        return result.Substring(0, result.Length - 1 );
    }

    /* Given a list of words followed by two words, 
    the task to find the minimum distance between the given two words in the list of words */
    public static int ShortestDistance(List<string> list, string word1, string word2)
	{
        int minDistance = 0;
        if(word1 == word2) return minDistance;
		for (int i = 0; i < list.Count; i++)
        {
            if(list[i] == word1)
            {
                minDistance = 0;
                continue;
            }
            minDistance++; 
            if(list[i] == word2) 
            {
                break;
            }            
        }
        return minDistance;
	}
}
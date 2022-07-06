namespace LeetCode.Collections;

public class Program
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        int alphabet = 52;
        int[] temp = new int[alphabet];

        for (int i = 0; i < s.Length; i++)
        {
            temp[Math.Abs(s[i] - 'a')]++;
            temp[Math.Abs(t[i] - 'a')]--;
        }
        
        foreach(var number in temp)
            if (number != 0)
                return false;

        return true;
    }
    static void Main()
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("Anagram", "nagaram"));
        Console.WriteLine(IsAnagram("rat", "car"));
    }
}
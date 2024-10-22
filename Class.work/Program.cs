using System;

public class Program1
{
    public static bool IsPalindrome(string input)
    {
        input = input.ToLower();

        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            if (input[start] != input[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    public static void Main()
    {
        string test = "racecar";
        Console.WriteLine(IsPalindrome(test));
    }
}
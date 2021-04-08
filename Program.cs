using System;

class Solution
{
    // In this challenge, you will determine whether a string is
    // funny or not. To determine whether a string is funny,
    // create a copy of the string in reverse e.g. abc -> cba.
    // Iterating through each string, compare the absolute difference
    // in the ascii values of the characters at positions 0 and 1,
    // 1 and 2 and so on to the end. If the list of absolute
    // differences is the same for both strings, they are funny.

    // Determine whether a given string is funny. 
    // If it is, return Funny, otherwise return Not Funny.

    // Complete the funnyString function below.
    static string funnyString(string s)
    {
        // Walk the string forward (fidx) and reverse (ridx)
        for (int fidx = 0, ridx = s.Length - 1; fidx < s.Length - 1; fidx++, ridx--)
        {
            if (Math.Abs(s[fidx] - s[fidx+1]) != Math.Abs(s[ridx] - s[ridx-1]))
            {
                return "Not Funny";
            }
        }

        return "Funny";
    }

    static void Main(string[] args)
    {
        string[] testcases = new string[]
        {
            "acxz",
            "bcxz",
        };

        foreach(string testcase in testcases)
        {
            string result = funnyString(testcase);

            Console.WriteLine(result);
        }
    }
}

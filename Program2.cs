using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (m): ");
        int m = int.Parse(Console.ReadLine());

        // Ensure n is less than m
        if (n > m)
        {
            int temp = n;
            n = m;
            m = temp;
        }

        Console.WriteLine($"Mirror numbers between {n} and {m}:");
        for (int i = n; i <= m; i++)
        {
            if (IsMirrorNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsMirrorNumber(int number)
    {
        string strNum = number.ToString();
        string reversedStrNum = ReverseString(strNum);
        return strNum.Equals(reversedStrNum, StringComparison.OrdinalIgnoreCase);
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}


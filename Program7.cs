using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Here are some numbers: 0123456789, 0234567890, and 0123456780. Also, 0123456789 is repeated.";

        List<string> phoneNumbers = ExtractPhoneNumbers(input);

        if (phoneNumbers.Count >= 2)
        {
            Console.WriteLine("Valid phone numbers found:");
            foreach (var number in phoneNumbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("Not enough valid phone numbers found.");
        }
    }

    static List<string> ExtractPhoneNumbers(string input)
    {
        // Regex pattern for matching phone numbers starting with '0' and having exactly 10 digits
        string pattern = @"\b0\d{9}\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        // Use a HashSet to ensure we only keep unique numbers
        HashSet<string> uniqueNumbers = new HashSet<string>();

        foreach (Match match in matches)
        {
            uniqueNumbers.Add(match.Value);
        }

        return uniqueNumbers.ToList();
    }
}

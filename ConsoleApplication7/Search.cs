using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication7
{
    class Search
    {
        public static void MatchString(string stringToMatch, string filePath)
        {
            var contents =
                File.ReadAllText(filePath);
            var testRegex = new Regex(stringToMatch);
            var present = testRegex.IsMatch(contents);

            if (present)
            {
                Console.WriteLine($"Present in {filePath}");
            }
            else
            {
                Console.WriteLine("Not present");
            }
        }
    }
}
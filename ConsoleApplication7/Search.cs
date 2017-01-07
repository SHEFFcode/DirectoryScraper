using System;
using System.IO;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using SpreadsheetLight;

namespace ConsoleApplication7
{
    class Search
    {
        public static void MatchString(string stringToMatch, string filePath, int aString, int bString, SLDocument sl)
        {
            var contents =
                File.ReadAllText(filePath);
            var testRegex = new Regex(stringToMatch);
            var present = testRegex.IsMatch(contents);

            if (present)
            {
                Console.WriteLine($"Present in {filePath}");
                Excel.SaveToExcel(stringToMatch, filePath, aString, bString, sl);
            }
            else
            {
                Console.WriteLine("Not present");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication7
{
    class Crawler
    {
        public List<string> DirSearch(string sDir, string fName, string searchParam)
        {
            var txtFile = fName;
            var fileList = new List<string>();
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, txtFile))
                    {
                        fileList.Add(f);
                    }
                    DirSearch(d, txtFile, searchParam);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            var matchespathsThatMatchSearchParam = MatchString(searchParam, fileList);

            return matchespathsThatMatchSearchParam;
        }

        private List<string> MatchString(string stringToMatch, List<string> fileList)
        {
            var testRegex = new Regex(stringToMatch);
            var pathsThatMatchSearchParam = new List<string>();

            foreach (var file in fileList)
            {
                var contents =
                File.ReadAllText(file);
                var present = testRegex.IsMatch(contents);
                if (present)
                {
                    Console.WriteLine($"Present in {file}");
                    pathsThatMatchSearchParam.Add(file);
                }
                else
                {
                    Console.WriteLine("Not present");
                }
            }
            return pathsThatMatchSearchParam;
        }
    }
}
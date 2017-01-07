using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication7
{
    class Crawler
    {
        public static void DirSearch(string sDir, string fName)
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
                    DirSearch(d, txtFile);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            foreach (var file in fileList)
            {
                Search.MatchString("Hello there!", file);
            }
        }
    }
}
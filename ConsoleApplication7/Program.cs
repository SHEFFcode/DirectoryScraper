using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using SpreadsheetLight;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler.DirSearch(@"C:\Users\whitehawk\Documents\Visual Studio 2015\Projects\ConsoleApplication7\", "index.html");
            Excel.SaveToExcel("Hello There!", "A1");
        }
    }
}

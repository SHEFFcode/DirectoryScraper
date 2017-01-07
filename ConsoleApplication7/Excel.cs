using System;
using SpreadsheetLight;

namespace ConsoleApplication7
{
    class Excel
    {
        public static void SaveToExcel(string data, string cell)
        {
            SLDocument sl = new SLDocument();

            // set a the value of data to the correct cell.
            sl.SetCellValue("A1", data);

            sl.SaveAs("HelloWorld.xlsx");

            Console.WriteLine("End of program");
            Console.ReadLine();

        }
    }
}
using System;
using DocumentFormat.OpenXml.Wordprocessing;
using SpreadsheetLight;

namespace ConsoleApplication7
{
    class Excel
    {

        public static void SaveToExcel(string aData, string bData, int aNumber, int bNumber, SLDocument sl)
        {
            var cellA = "A" + aNumber;
            var cellB = "B" + bNumber;

            

            // set a the value of data to the correct cell.
            try
            {
                sl.SetCellValue(cellA, aData);


                sl.SetCellValue(cellB, bData);

            }
            catch (Exception)
            {
                    
                throw new Exception("Something went wrong");
            }
            
        }
    }
}
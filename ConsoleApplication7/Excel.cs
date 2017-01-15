using System;
using System.Collections.Generic;
using SpreadsheetLight;

namespace ConsoleApplication7
{
    class Excel
    {
        private SLDocument _document = new SLDocument();

        private void cellPopulator(List<string> itemToPopulate, int _columnNumber, string results)
        {
            var rowNumber = 1;
            var columnNumber = _columnNumber;
            foreach (var item in itemToPopulate)
            {
                try
                {
                    _document.SetCellValue(rowNumber, _columnNumber, item);
                    _document.SetColumnWidth(columnNumber, 100);
                    _document.SetCellValue(rowNumber, _columnNumber + 1, results);
                    _document.SetColumnWidth(columnNumber + 1, 10);
                    rowNumber++;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Something went wrong, error: {ex}");
                }
            }
        }

        public void SaveToExcel(List<string> matches, string results)
        {
            cellPopulator(matches, 1, results);
            _document.SaveAs("HelloWorld.xlsx");
        }
    }
}
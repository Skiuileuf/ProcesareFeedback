using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ProcesareFeedback
{
    public class ExcelProcessor
    {
        public readonly XLWorkbook WorkBook;
        public readonly IXLWorksheet WorkSheet;

        public ExcelProcessor(string Path)
        {
            //this.Path = Path;
            WorkBook = new XLWorkbook(Path);
            WorkSheet = WorkBook.Worksheets.First();
        }

        public IXLCell GetCellValue(int row, int column)
        {
            return WorkSheet.Cell(row, column);
        }

        public IXLCell GetCellValue(string address)
        {
            return WorkSheet.Cell(address);
        }

        public int GetWidth(int row)
        {
            int current = 1;

            //while ( !string.IsNullOrEmpty(WorkSheet.Cells[row, current].Value2))
            while (!WorkSheet.Cell(row, current).IsEmpty())
            {
                current++;
            }
            return current - 1;
        }
        public int GetHeigth(int col)
        {
            int current = 1;

            //while (!string.IsNullOrEmpty(WorkSheet.Cells[current, col].Value2))
            while (!WorkSheet.Cell(current, col).IsEmpty())
            {
                current++;
            }
            return current - 1;
        }

        //public Range GetHeader()
        //{
        //    return WorkSheet.Range[WorkSheet.Cells[1,1], WorkSheet.Cells[1,GetWidth(1)]];
        //}

        //public string[,] ReadRange(int startRow, int startCol, int endRow, int endCol)
        //{
        //    Range range = (Range)WorkSheet.Range[WorkSheet.Cells[startRow, startCol], WorkSheet.Cells[endRow, endCol]];
        //    object[,] holder = range.Value2;
        //    string[,] returnstring = new string[endRow - startRow, endCol - startCol];
        //    for(int i = 1; i <= endRow - startRow; i++)
        //    {
        //        for(int j = 1; j <= endCol - startCol; j++)
        //        {
        //            returnstring[i - 1, j - 1] = holder[i, j].ToString();
        //        }
        //    }
        //    return returnstring;

        //}


        ~ExcelProcessor()
        {
            WorkBook.Dispose();
        }
    }
}

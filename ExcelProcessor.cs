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
            try
            {
                WorkBook = new XLWorkbook(Path);
            } catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
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

        ~ExcelProcessor()
        {
            WorkBook.Dispose();
        }
    }
}

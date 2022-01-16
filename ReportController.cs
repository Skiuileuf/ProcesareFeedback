using SharpDocx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesareFeedback
{
    internal class ReportController
    {
        public static void GenerateReport(TeacherReport report)
        {
            var ViewPath = $"D:\\Desktop\\Report.cs.docx"; //template.cs.docx
            var documentPath = $"D:\\Desktop\\feedback\\{report.NCLASA}{report.LCLASA}-{report.PROFESOR}-{report.DISCIPLINA}.docx";//result.docx
            //var model = CreateViewModel(report);
            var model = report;

            DocumentBase document = DocumentFactory.Create(ViewPath, model);

            document.Generate(documentPath, model);
        }
    }
}

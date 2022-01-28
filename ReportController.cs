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
            var documentFolder = $"D:\\Desktop\\Feedback{report.NCLASA}{report.LCLASA}";
            if (!Directory.Exists(documentFolder)) Directory.CreateDirectory(documentFolder);
            var documentName = $"{report.NCLASA}{report.LCLASA}-{report.DISCIPLINA.ToUpperInvariant()}-{report.PROFESOR}.docx";
            //var documentPath = $"D:\\Desktop\\feedback\\";//result.docx
            var documentPath = Path.Combine(documentFolder, documentName);
            //var model = CreateViewModel(report);
            var model = report;

            DocumentBase document = DocumentFactory.Create(ViewPath, model);

            document.Generate(documentPath, model);
        }
    }
}

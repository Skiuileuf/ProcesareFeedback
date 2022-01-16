using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ProcesareFeedback
{
    public partial class MainForm : Form
    {
        //public static TeacherReport BaseReport;

        public MainForm()
        {
            InitializeComponent();
        }

        public string ExcelPath;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelPath = openFileDialog.FileName;
                pathBox.Text = ExcelPath;
                generateButton.Enabled = File.Exists(ExcelPath);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //BaseReport = new TeacherReport
            //{
            //    NCLASA = nclasa.Text,
            //    LCLASA = lclasa.Text,
            //    ANSCOLAR = anscolar.Text,
            //    SEMESTRU = semestru.Text,
            //    NRELEVI = nrelevi.Text,
            //    DIRIGINTE = diriginte.Text
            //};

            ExcelProcessor ep = new ExcelProcessor(ExcelPath);

            List<FeedbackRecord> records = new List<FeedbackRecord>();
            SortedSet<string> discipline = new SortedSet<string>();

            //Obtine latimea foii de calcul. TODO latime constanta?
            //int Width = ep.GetWidth(1);

            //Pentru fiecare rand in afara de header genereaza un obiect care stocheaza feedbackul
            for (int i = 2; i <= ep.GetHeigth(1); i++)
            {
                DateTime timestamp = ep.GetCellValue(i, 1).GetDateTime();
                string pd = ep.GetCellValue(i, 2).GetString();
                string prezenta = ep.GetCellValue(i, 21).GetString();
                string mesaj = ep.GetCellValue(i, 21 - 1).GetString();
                string dorinta = ep.GetCellValue(i, 21 - 2).GetString();
                int num = 16; //TODO AUTODETERMINARE

                int[] raspunsuri = new int[num];

                for (int j = 1; j <= num; j++)
                {
                    raspunsuri[j - 1] = (int)ep.GetCellValue(i, j + 2).GetDouble();
                }

                FeedbackRecord record = new FeedbackRecord(timestamp, pd, raspunsuri, dorinta, mesaj, prezenta);
                records.Add(record);
                discipline.Add(record.Disciplina);
            }

            //MessageBox.Show(records.Count.ToString());


            //Pentru fiecare materie diferita
            foreach (string disciplina in discipline)
            {
                TeacherReport report = new TeacherReport()//BaseReport);
                {
                    NCLASA = nclasa.Text,
                    LCLASA = lclasa.Text,
                    ANSCOLAR = anscolar.Text,
                    SEMESTRU = semestru.Text,
                    NRELEVI = nrelevi.Text,
                    DIRIGINTE = diriginte.Text
                };


                List<FeedbackRecord> localRecords = records.Where(rd => rd.Disciplina.Equals(disciplina)).ToList();
                List<string> dorinte = new List<string>();
                List<string> mesaje = new List<string>();

                Dictionary<string, int> prezenta = new Dictionary<string, int>();


                report.NRFEEDBACK = localRecords.Count().ToString();
                report.PROFESOR = localRecords.First().Profesor;
                report.DISCIPLINA = localRecords.First().Disciplina;

                report.DORINTA1 = report.DORINTA2 = report.MESAJ1 = report.MESAJ2 = "PLACEHOLDER MESAJ";

                report.PROCENTPARTICIPARE = "PROCENT PARTICIPARE PESTE 9000";

                foreach(FeedbackRecord rec in localRecords)
                {
                    for (int i = 0; i < rec.Raspunsuri.Length; i++)
                    {
                        report.numere[i, rec.Raspunsuri[i] - 1]++;
                    }
                    dorinte.Add(rec.Dorinta);
                    mesaje.Add(rec.Mesaj);

                    if (prezenta.ContainsKey(rec.Prezenta))
                    {
                        prezenta[rec.Prezenta]++;
                    } else
                    {
                        prezenta.Add(rec.Prezenta, 0);
                    }
                }

                IOrderedEnumerable<string> dorinteSortate = dorinte.OrderBy(x => x.Length);
                IOrderedEnumerable<string> mesajeSortate = mesaje.OrderBy(x => x.Length);

                report.DORINTA1 = dorinte[0].Trim('\n');
                report.DORINTA2 = dorinte[1].Trim('\n');

                report.MESAJ1 = mesaje[0].Trim('\n');
                report.MESAJ2 = mesaje[1].Trim('\n');

                report.PROCENTPARTICIPARE = (from entry in prezenta orderby entry.Value descending select entry).First().Key.ToLower();

                //MessageBox.Show($"{disciplina} {localRecords.Count()}");
                ReportController.GenerateReport(report);
            }

            

            MessageBox.Show("DONE");
        }


    }
}

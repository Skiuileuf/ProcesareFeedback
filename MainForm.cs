using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ProcesareFeedback
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string ExcelPath;
        public string TemplatePath;
        public string SavePath;

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
                ParseFileName(ExcelPath);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            ExcelProcessor ep = new ExcelProcessor(ExcelPath);

            //Make a list of all the records parsed from the excel file
            List<FeedbackRecord> records = new List<FeedbackRecord>();
            //Sorteaza o lista de valori unice ca sa stim cate discipline avem
            SortedSet<string> discipline = new SortedSet<string>();

            List<string> intrebari = new List<string>();
            //Orice intrebare incepe cu [ deci de luat in considerare in viitor
            for(int i = 3; i <= 18; i++)
            {
                intrebari.Add(ep.WorkSheet.Cell(1, i).GetString());
            }

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


            //Pentru fiecare materie diferita
            foreach (string disciplina in discipline)
            {
                //Genereaza un raport nou care porneste de la parametri prestabiliti
                TeacherReport report = new TeacherReport()
                {
                    NCLASA = nclasa.Text,
                    LCLASA = lclasa.Text,
                    ANSCOLAR = anscolar.Text,
                    SEMESTRU = semestru.Text,
                    NRELEVI = nrelevi.Text,
                    DIRIGINTE = diriginte.Text,
                    intrebari = intrebari
                };

                //Selecteaza toate inregistrarile pentru o anumita disciplina
                List<FeedbackRecord> localRecords = records.Where(rd => rd.Disciplina.Equals(disciplina)).ToList();

                //Liste pentru dorinte si mesaje
                List<string> dorinte = new List<string>();
                List<string> mesaje = new List<string>();

                //Dictionar pentru prezenta, contorizeaza procentul de elevi prezenti TODO: varianta mai eficienta??
                Dictionary<string, int> prezenta = new Dictionary<string, int>();

                //Preia datele care sunt valabile pentru toate inregistrarile
                report.NRFEEDBACK = localRecords.Count().ToString();
                report.PROFESOR = localRecords.First().Profesor;
                report.DISCIPLINA = localRecords.First().Disciplina;

                foreach(FeedbackRecord rec in localRecords)
                {
                    //centralizeaza notele pentru fiecare profesor
                    //TODO: explicatie algoritm
                    for (int i = 0; i < rec.Raspunsuri.Length; i++)
                    {
                        report.numere[i, rec.Raspunsuri[i] - 1]++;
                    }

                    //Adauga dorintele si mesajele la liste
                    if (rec.Dorinta.Length > 3) dorinte.Add(rec.Dorinta.Trim());
                    if (rec.Mesaj.Length > 3) mesaje.Add(rec.Mesaj.Trim());

                    //Proceseaza prezenta.
                    if (prezenta.ContainsKey(rec.Prezenta))
                    {
                        prezenta[rec.Prezenta]++;
                    } else
                    {
                        prezenta.Add(rec.Prezenta, 0);
                    }
                }

                //calculare medii aritmetice
                for (int i = 0; i < report.numere.GetLength(0); i++)
                {
                    double mediaLocala = 0;
                    for (int j = 0; j < report.numere.GetLength(1); j++)
                    {
                        mediaLocala += report.numere[i, j] * (j+1);
                    }
                    if (i > 0 && i <= 4) report.MEDIEPREDARE += mediaLocala;
                    if (i > 4 && i <= 11) report.MEDIEATMOSFERA += mediaLocala;
                    if (i > 11 && i <= 15) report.MEDIESTATUT += mediaLocala;

                }

                report.MEDIEPREDARE /= 5 * int.Parse(report.NRFEEDBACK);
                report.MEDIEATMOSFERA /= 7 * int.Parse(report.NRFEEDBACK);
                report.MEDIESTATUT /= 4 * int.Parse(report.NRFEEDBACK);

                //Sorteaza dorintele si mesajele
                IOrderedEnumerable<string> dorinteSortate = dorinte.OrderBy(x => x.Length);
                IOrderedEnumerable<string> mesajeSortate = mesaje.OrderBy(x => x.Length);

                report.DORINTE = dorinteSortate.ToList();

                report.MESAJE = mesajeSortate.ToList();

                //Selecteaza cheia de dictionar cu valoarea cea mai mare
                report.PROCENTPARTICIPARE = (from entry in prezenta orderby entry.Value descending select entry).First().Key.ToLower();

                //Trimite raportul catre generare
                ReportController.GenerateReport(report);
            }

            MessageBox.Show("DONE");
        }

        public void ParseFileName(string path)
        {
            string name = Path.GetFileName(path);
            //MessageBox.Show(name);

            string PatternClasa = @"(X{0,3})(IX|IV|V?I{0,3})(?=-)";
            Match clasa = Regex.Match(name, PatternClasa);

            string PatternLitera = @"([A-Z]{1,2}[0-9]{0,1})(?= )";
            Match litera = Regex.Match(name, PatternLitera);

            string PatternSemestru = @"(I{1,2})(?=,)";
            Match semestru = Regex.Match(name, PatternSemestru);

            string PatternAnScolar = @"[0-9]{4}-[0-9]{4}";
            Match anScolar = Regex.Match(name, PatternAnScolar);

            //MessageBox.Show($"{name} \n {clasa.Value} {litera.Value} {semestru.Value} {anScolar.Value}");

            nclasa.Text = clasa.Value;
            lclasa.Text = litera.Value;
            this.semestru.Text = semestru.Value;
            this.anscolar.Text = anScolar.Value;
        }

        private void tabUpload_Click(object sender, EventArgs e)
        {

        }
    }
}

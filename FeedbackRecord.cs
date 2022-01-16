using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesareFeedback
{
    //Reprezinta un rand in tabelul din excel
    public class FeedbackRecord
    {
        public DateTime Timestamp;
        public string Disciplina;
        public string Profesor;
        public int[] Raspunsuri;
        public string Dorinta;
        public string Mesaj;
        public string Prezenta;

        public FeedbackRecord(DateTime Timestamp, string DiscSiProf, int[] Raspunsuri, string Dorinta, string Mesaj, string Prezenta)
        {
            this.Timestamp = Timestamp;

            string[] DsP = DiscSiProf.Split('-');
            Disciplina = DsP[0].Trim();
            Profesor = DsP[1].Trim();

            this.Raspunsuri = Raspunsuri;

            this.Dorinta = Dorinta;
            this.Mesaj = Mesaj;
            this.Prezenta = Prezenta;
        }
    }
}
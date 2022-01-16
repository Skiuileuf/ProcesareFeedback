using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesareFeedback
{
    //reprezinta continutul unui raport
    public class TeacherReport
    {
#pragma warning disable CS0649, 0649
        //In principal constante obtinute din form
        public string NCLASA; //nume clasa - exemplu: VIII, XII
        public string LCLASA; //litera clasa - exemplu: A, B, F, MI, SN, U
        public string ANSCOLAR; //anul scolar in format yyyy-yyyy - exemplu: 2021-2022
        public string SEMESTRU; //semestru - exemplu: I, II
        public string NRELEVI; //numarul total de elevi din clasa
        public string DIRIGINTE; //dirigintele clasei


        public string PROFESOR; //nume profesor evaluat
        public string DISCIPLINA; //materia predata de profesorul evaluat - exemplu: matematica
        public string NRFEEDBACK; //numarul de elevi care au acordat feedback

        //cele mai lungi doua mesaje din lista de mesaje
        public string DORINTA1;
        public string DORINTA2;

        //cele mai lungi doua mesaje pentru profesor din lista de mesaje
        public string MESAJ1;
        public string MESAJ2;

        //procentul de participare al elevilor
        public string PROCENTPARTICIPARE;

        public int[,] numere = new int[16, 5];
#pragma warning restore CS0649, 0649

        private int index = 0;
        public int GetRunIndex()
        {
            int res = index;
            index++;
            return index;
        }

        private int numIndex = 0;
        public int GetNumValue()
        {
            int[] to = numere.Cast<int>().ToArray();
            //if (numIndex > numere.Length) return -1;
            //int res = numere[numIndex / 5, numIndex % 5];
            //int res = numIndex;
            int res = to[numIndex];
            numIndex++;
            return res;
        }
    }
}

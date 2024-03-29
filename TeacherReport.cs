﻿using System;
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
        public List<string> DORINTE;

        //cele mai lungi doua mesaje pentru profesor din lista de mesaje
        public List<string> MESAJE;

        public double MEDIEPREDARE;
        public double MEDIEATMOSFERA;
        public double MEDIESTATUT;

        //procentul de participare al elevilor
        public string PROCENTPARTICIPARE;

        public int[,] numere = new int[16, 5];
        public List<string> intrebari;
#pragma warning restore CS0649, 0649

        private int index = 0;
        public int GetRunIndex()
        {
            int res = index;
            index++;
            return index;
        }

        //inlocuitor pentru IENUMERATOR cu yield return
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

        private int questionIndex = 0;
        public string GetQuestion()
        {
            string q = intrebari[questionIndex].Trim().Trim(new char[] { '[', ']' });
            questionIndex++;
            return q;
        }

        public string Masura(double a)
        {
            // intr-o ... masura
            string result = "INVALID EROARE CALCUL ASTA NU TREBUIE SA APARA NICIUNDE";

            if (a > 0 && a <= 1) result = "foarte mica";
            if (a > 1 && a <= 2) result = "mica";
            if (a > 2 && a <= 3) result = "oarecare";
            if (a > 3 && a <= 4) result = "mare";
            if (a > 4 && a <= 5) result = "foarte mare";


            return result;
        }
    }
}

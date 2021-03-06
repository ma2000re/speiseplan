﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplanprojekt___Carina_Manuel
{
    public class Vorspeisen : Speisen
    {
        private bool veg;
        private string zusatz;

        private static int anzahl;

        public Vorspeisen(string SID, string speisenart, string name, string wk):base(SID,speisenart,name,wk)
        {
            anzahl++;
        }
        public Vorspeisen(string SID, string speisenart, string name, string wk, string zusatz, bool veg) :base (SID,speisenart,name,wk)
        {
            this.veg = veg;
            this.zusatz = zusatz;
            anzahl++;
        }

        public bool Veg
        {
            get { return veg; }
            set { veg = value; }
        }
        public string Zusatz
        {
            get { return zusatz; }
            set { zusatz = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + veg + "\t" + zusatz;
        }
        public static int Anzahl
        {
            get { return anzahl; }
        }
        public static void setAnzahlMinusEins()
        {
            anzahl--;
        }
    }
}

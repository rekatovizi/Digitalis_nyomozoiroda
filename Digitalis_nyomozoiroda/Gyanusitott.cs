using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Gyanusitott:Szemely
    {
       
        private int gyanusitottsagi_szint;
        private string statusz;

        public Gyanusitott(string nev, int eletkor, int szint, string status) : base(nev, eletkor, "gyanusitott")
        {
            this.gyanusitottsagi_szint = szint;
            this.statusz = statusz;
        }

        public int Gyanusitottsagi_szint { get => gyanusitottsagi_szint; set => gyanusitottsagi_szint = value; }
        public string Statusz { get => statusz; set => statusz = value; }
        
    }
}

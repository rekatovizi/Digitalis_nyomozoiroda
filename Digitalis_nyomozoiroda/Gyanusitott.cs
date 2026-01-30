using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Gyanusitott
    {
        private Szemely gyanus_szemely;
        private int gyanusitottsagi_szint;
        private string statusz;

        public Gyanusitott(Szemely gyanus_szemely, int gyanusitottsagi_szint, string statusz)
        {
            this.gyanus_szemely = gyanus_szemely;
            this.gyanusitottsagi_szint = gyanusitottsagi_szint;
            this.statusz = statusz;
        }

        public int Gyanusitottsagi_szint { get => gyanusitottsagi_szint; set => gyanusitottsagi_szint = value; }
        public string Statusz { get => statusz; set => statusz = value; }
        internal Szemely Gyanus_szemely { get => gyanus_szemely; set => gyanus_szemely = value; }
    }
}

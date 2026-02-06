using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Bizonyitek
    {
        private string azonosito;
        private string tipus;
        private string leiras;
        private int megbizhatosagi_etek;

        public Bizonyitek(string azonosito, string tipus, string leiras, int megbizhatosagi_etek)
        {
            this.azonosito = azonosito;
            this.tipus = tipus;
            this.leiras = leiras;
            this.megbizhatosagi_etek = megbizhatosagi_etek;
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Megbizhatosagi_etek { get => megbizhatosagi_etek; set => megbizhatosagi_etek = value; }


        



    }
}

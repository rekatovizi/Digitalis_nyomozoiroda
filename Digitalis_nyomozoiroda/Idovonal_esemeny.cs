using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Idovonal_esemeny
    {
        private string datum;
        private string esemeny_leiras;

        public Idovonal_esemeny(string datum, string esemeny_leiras)
        {
            this.datum = datum;
            this.esemeny_leiras = esemeny_leiras;
        }

        public string Datum { get => datum; set => datum = value; }
        public string Esemeny_leiras { get => esemeny_leiras; set => esemeny_leiras = value; }
    }
}

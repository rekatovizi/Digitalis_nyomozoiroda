using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Ugy
    {
        private string ugyazonosito;
        private string cim;
        private string leiras;
        private string allapot;
        private List<Szemely> ugy_erintettek;
        private List<Bizonyitek> ugy_bizonyitekok;

        public Ugy(string ugyazonosito, string cim, string leiras, string allapot, List<Szemely> ugy_erintettek, List<Bizonyitek> ugy_bizonyitekok)
        {
            this.ugyazonosito = ugyazonosito;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;
            this.ugy_erintettek = ugy_erintettek;
            this.ugy_bizonyitekok = ugy_bizonyitekok;
        }

        public string Ugyazonosito { get => ugyazonosito; set => ugyazonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Allapot { get => allapot; set => allapot = value; }
        internal List<Szemely> Ugy_erintettek { get => ugy_erintettek; set => ugy_erintettek = value; }
        internal List<Bizonyitek> Ugy_bizonyitekok { get => ugy_bizonyitekok; set => ugy_bizonyitekok = value; }
    }
}

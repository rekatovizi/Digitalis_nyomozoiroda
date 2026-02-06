using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Adattar
    {
        private List<Ugy> ugyek;
        private List<Szemely> szemelyek;
        private List<Bizonyitek> bizonyitekok;

        public Adattar()
        {
            
            this.ugyek = [];
            this.szemelyek = [];
            this.bizonyitekok = [];
        }

        internal List<Ugy> Ugyek { get { return ugyek; } }
        internal List<Szemely> Szemelyek { get { return szemelyek; } }
        internal List<Bizonyitek> Bizonyitekok { get { return bizonyitekok; } }
    }
}

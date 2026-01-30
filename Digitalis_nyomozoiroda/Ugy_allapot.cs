using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Ugy_allapot
    {
        private string aktualis_allapot;

        public Ugy_allapot(string aktualis_allapot)
        {
            this.aktualis_allapot = aktualis_allapot;
        }

        public string Aktualis_allapot { get => aktualis_allapot; set => aktualis_allapot = value; }

        
    }
}

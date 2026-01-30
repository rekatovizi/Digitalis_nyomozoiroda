using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Tanu
    {
        private Szemely tanu_szemely;
        private string vallomas;
        private string vallomas_datuma;

        public Tanu(Szemely tanu_szemely, string vallomas, string vallomas_datuma)
        {
            this.tanu_szemely = tanu_szemely;
            this.vallomas = vallomas;
            this.vallomas_datuma = vallomas_datuma;
        }

        public string Vallomas { get => vallomas; set => vallomas = value; }
        public string Vallomas_datuma { get => vallomas_datuma; set => vallomas_datuma = value; }
        internal Szemely Tanu_szemely { get => tanu_szemely; set => tanu_szemely = value; }
    }
}

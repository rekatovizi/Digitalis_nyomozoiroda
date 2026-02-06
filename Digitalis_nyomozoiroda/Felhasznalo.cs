using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Felhasznalo:Szemely
    {
       
        private string azonosito;
       

        public Felhasznalo(string nev, int eletkor, string megjegyzes, string azonosito ) : base(nev, eletkor, "felhasználó")
        {
            this.azonosito = azonosito;
        }

       
        public string Azonosito { get => azonosito; set => azonosito = value; }

    }
}

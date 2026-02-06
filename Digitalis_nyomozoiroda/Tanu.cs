using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozoiroda
{
    internal class Tanu:Szemely
    {
       
        private string vallomas;
        private string vallomas_datuma;

        public Tanu(string nev, int eletkor) : base(nev, eletkor, "tanu")
        {
        }

        public void VallomasFelvetel(string vallomas)
        {
            this.vallomas = vallomas;
            this.vallomas_datuma = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        public string Vallomas { get => vallomas; set => vallomas = value; }
        public string Vallomas_datuma { get => vallomas_datuma; set => vallomas_datuma = value; }
      
    
        public override string ToString()
        {
            return base.ToString()+" \nVallomás: "+Vallomas+" (Dátum: "+Vallomas_datuma;
        }

    }
}

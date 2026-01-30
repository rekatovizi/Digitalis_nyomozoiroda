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

        public void Bizonyitek_hozzaadasa(Ugy ugy)
        {
            string valasz;
            do
            {
                Console.WriteLine("Szeretne új bizonyítékot hozzáadni? (i/n)");
                valasz = Console.ReadLine();
                if (valasz == "i")
                {
                    Console.Write("Adja meg a bizonyíték azonosítóját: ");
                    string uj_azonosito = Console.ReadLine();
                    Console.Write("Adja meg a bizonyíték típusát: ");
                    string uj_tipus = Console.ReadLine();
                    Console.Write("Adja meg a bizonyíték leírását: ");
                    string uj_leiras = Console.ReadLine();
                    Console.Write("Adja meg a bizonyíték megbízhatósági értékét (1-10): ");
                    int uj_megbizhatosagi_ertek = int.Parse(Console.ReadLine());
                    Bizonyitek uj_bizonyitek = new Bizonyitek(uj_azonosito, uj_tipus, uj_leiras, uj_megbizhatosagi_ertek);
                    ugy.Ugy_bizonyitekok.Add(uj_bizonyitek);
                    Console.WriteLine("Új bizonyíték hozzáadva.");
                }
                else if (valasz != "n")
                {
                    Console.WriteLine("nincs új bizonyíték");
                }
                else
                {
                    Console.WriteLine("Érvénytelen válasz, kérem adja meg újra.");
                }

            } while (valasz!="i" && valasz!="n");
            
        }

        

    }
}

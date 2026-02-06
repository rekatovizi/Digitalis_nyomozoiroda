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

        public Ugy(string ugyazonosito, string cim, string leiras, string allapot)
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

        public string allapotvizsgalat()
        {
            string valasz;
            do
            {
                Console.WriteLine($"Az ügy aktuális állapota: {this.allapot} szeretne rajta változtatni?(i/n))");
                valasz = Console.ReadLine();
                if (valasz == "i")
                {
                    Console.WriteLine("Adja meg az új állapotot:");
                    string ujallapot = Console.ReadLine();
                    this.allapot = ujallapot;
                    Console.WriteLine($"Az ügy állapota megváltozott: {allapot}");
                }
                else if (valasz == "n")
                {
                    Console.WriteLine("Az ügy állapota nem változott.");
                }
                else
                {
                    Console.WriteLine("Érvénytelen válasz.");
                }
            } while (valasz != "i" && valasz != "n");
            return allapot;
        }
        public void Bizonyitek_hozzaadasa(Bizonyitek b)
        {
            if (ugy_bizonyitekok.Contains(b))
            {
                Console.WriteLine("Ez a bizonyíték már hozzá van adva az ügyhöz.");
            }
            else
            {
                ugy_bizonyitekok.Add(b);
                Console.WriteLine("Bizonyíték hozzáadva az ügyhöz.");
            }
        }
        public void Bizonyitek_hozzaadasa_egyesevel()
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
                    ugy_bizonyitekok.Add(uj_bizonyitek);
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

            } while (valasz != "i" && valasz != "n");

        }
        public void Bizonyitek_torlese(Bizonyitek b)
        {
            if (ugy_bizonyitekok.Contains(b))
            {
                ugy_bizonyitekok.Remove(b);
                Console.WriteLine("Bizonyíték törölve az ügyből.");
            }
            else
            {
                Console.WriteLine("Ez a bizonyíték nem található az ügyben.");
            }
        }
        public void Erintettek_hozzaadasa_egyesevel()
        {
            string valasz;
            do
            {
                Console.WriteLine("Szeretne új érintettet hozzáadni? (i/n)");
                valasz = Console.ReadLine();
                if (valasz == "i")
                {
                    Console.Write("Adja meg az érintett nevét: ");
                    string uj_nev = Console.ReadLine();
                    Console.Write("Adja meg az érintett életkorát: ");
                    int uj_eletkor = int.Parse(Console.ReadLine());
                    Console.Write("Adja meg az érintett nemét: ");
                    string uj_nem = Console.ReadLine();
                    Szemely uj_erintett = new Szemely(uj_nev, uj_eletkor, uj_nem);
                    ugy_erintettek.Add(uj_erintett);
                    Console.WriteLine("Új érintett hozzáadva.");
                }
                else if (valasz != "n")
                {
                    Console.WriteLine("nincs új érintett");
                }
                else
                {
                    Console.WriteLine("Érvénytelen válasz, kérem adja meg újra.");
                }
            } while (valasz != "i" && valasz != "n");
        }
        public void Erintettek_hozzaadasa(Szemely s)
        {
            if (ugy_erintettek.Contains(s))
            {
                Console.WriteLine("Ez az érintett már hozzá van adva az ügyhöz.");
            }
            else
            {
               ugy_erintettek.Add(s);
            }
                
        }

        

    }
}
using System.ComponentModel;

namespace Digitalis_nyomozoiroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adattar adattar = new Adattar();
            bool fut = true;
            string valasz;
            string valasztas;
            do 
            {
                Console.WriteLine("Nyomozói iroda rendszer");
                Console.WriteLine("0 Kilépés, 1 Ügyek kezelése, 2 Személyek kezelése, 3 Bizonyítékok kezelése, 4 Idővonal megtekintése, 5 Elemzés/Döntések");
                Console.WriteLine("(csak számot írj)");
                Console.Write("Válassz egy opciót: ");
                valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "1":
                        valasztas = "";
                        Console.WriteLine("1 Új ugy létrehozása, 2 Ugy törlése, 3 Állapot változtatás, 4 Bizonyíték hozzáadása, 5 bizonyíték törlése, 6 érintettek hozzáadása, 7 érintettek törlése ");
                        valasztas = Console.ReadLine();
                        switch (valasztas)
                        {
                            case "1":
                                // ugyek kezelése
                                do
                                {
                                    Console.WriteLine("Szeretnél új ügyet hozzáadni?(i/n)");
                                    valasz = Console.ReadLine();
                                    if (valasz.ToLower() == "i")
                                    {
                                        Console.Write("Add meg az ügy azonosítóját: ");
                                        string ugyAzonosito = Console.ReadLine();
                                        Console.Write("Add meg az ügy típusát: ");
                                        string ugyTipus = Console.ReadLine();
                                        Console.Write("Add meg az ügy leírását: ");
                                        string ugyLeiras = Console.ReadLine();
                                        Console.Write("Add meg az ügy állapotát: ");
                                        string ugyAllapot = Console.ReadLine();
                                        Ugy ujUgy = new Ugy(ugyAzonosito, ugyTipus, ugyLeiras, ugyAllapot);
                                        adattar.Ugyek.Add(ujUgy);
                                        Console.WriteLine("Új ügy hozzáadva!");
                                    }
                                    else if (valasz.ToLower() == "n")
                                    {
                                        Console.WriteLine("Nem adtál hozzá új ügyet.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Érvénytelen válasz, kérlek válassz 'i' vagy 'n'!");
                                    }
                                } while (valasz.ToLower() != "i" && valasz.ToLower() != "n");
                                break;
                            case "2":
                                Console.Write("Add meg az ügy azonosítóját, amelyet törölni szeretnél: ");
                                string ugyAzonositoTorol = Console.ReadLine();
                                Ugy ugyTorol = adattar.Ugyek.Find(u => u.Ugyazonosito == ugyAzonositoTorol);
                                if (ugyTorol != null)
                                {
                                    adattar.Ugyek.Remove(ugyTorol);
                                    Console.WriteLine("Ügy törölve!");
                                }
                                else
                                {
                                    Console.WriteLine("Nem található ilyen azonosítóval rendelkező ügy.");
                                }
                                break;
                            case "3":
                                Console.Write("Add meg az ügy azonosítóját, amelynek az állapotát változtatni szeretnéd: ");
                                string ugyAzonositoValtoztat = Console.ReadLine();
                                Ugy ugyValtoztat = adattar.Ugyek.Find(u => u.Ugyazonosito == ugyAzonositoValtoztat);
                                ugyValtoztat.allapotvaltosztatas();
                                break;
                            case "4":
                                Console.Write("Add meg az ügy azonosítóját, amelyhez bizonyítékot szeretnél hozzáadni: ");
                                string ugyAzonositoBizonyitek = Console.ReadLine();
                                Ugy ugyBizonyitek = adattar.Ugyek.Find(u => u.Ugyazonosito == ugyAzonositoBizonyitek);
                                ugyBizonyitek.Bizonyitek_hozzaadasa_egyesevel();
                                break;
                            case "5":
                                Console.Write("Add meg az ügy azonosítóját, amelyből bizonyítékot szeretnél törölni: ");
                                string ugyAzonositoBizonyitekTorol = Console.ReadLine();
                                Ugy ugyBizonyitekTorol = adattar.Ugyek.Find(u => u.Ugyazonosito == ugyAzonositoBizonyitekTorol);
                                Console.Write("Add meg a bizonyíték azonosítóját, amelyet törölni szeretnél: ");
                                string bizonyitekAzonositoTorol = Console.ReadLine();
                                Bizonyitek bizonyitekTorol = ugyBizonyitekTorol.Ugy_bizonyitekok.Find(b => b.Azonosito == bizonyitekAzonositoTorol);
                                ugyBizonyitekTorol.Bizonyitek_torlese(bizonyitekTorol);
                                break;
                            case "6":
                                Console.Write("Add meg az ügy azonosítóját, amelyhez érintettet szeretnél hozzáadni: ");
                                string ugyAzonositoErintett = Console.ReadLine();
                                Ugy ugyErintett = adattar.Ugyek.Find(u => u.Ugyazonosito == ugyAzonositoErintett);
                                ugyErintett.Erintettek_hozzaadasa_egyesevel();
                                break;
                            case "7":
                                Console.Write("Add meg az ügy azonosítóját, amelyből érintettet szeretnél törölni: ");
                                string ugyAzonositoErintettTorol = Console.ReadLine();
                                Ugy ugyErintettTorol = adattar.Ugyek.Find(u => u.Ugyazonosito == ugyAzonositoErintettTorol);
                                Console.Write("Add meg az érintett nevét, amelyet törölni szeretnél: ");
                                string erintettNevTorol = Console.ReadLine();
                                Szemely erintettTorol = ugyErintettTorol.Ugy_erintettek.Find(s => s.Nev == erintettNevTorol);
                                ugyErintettTorol.Erintettek_torlese(erintettTorol);
                                break;

                        }
                        break;
                    case "2":
                        // Szemelyek kezelése
                        break;
                    case "3":
                        // Bizonyítékok kezelése
                        break;
                    case "4":
                        // idővonal megtekintése
                        break;
                    case "5":
                        // Elemzés/Döntések kezelése
                        break;
                    case "0":
                        Console.WriteLine("Kilépés...");
                        fut = false;
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás, próbáld újra.");
                        break;
                }
            } while (fut);

            //Felhasznalo felhasznalo1 = new Felhasznalo("Kovács",32, "1233234CĐ", "nyomozó");
            //Felhasznalo felhasznalo2 = new Felhasznalo("Nagy",45, "9876543AĐ", "adminisztrátor");
            //Felhasznalo felhasznalo3 = new Felhasznalo("Tóth",23, "4567890BĐ", "elemző");

            //Bizonyitek bizonyitek1 = new Bizonyitek("1232fvfm", "Fizikai", "Ujjlenyomat a helyszínről", 9);
            //Bizonyitek bizonyitek2 = new Bizonyitek("9876ghgh", "Digitális", "E-mailek a gyanúsítottról", 8);
            //Bizonyitek bizonyitek3 = new Bizonyitek("4567jklj", "Tanúvallomás", "Szemtanú beszámolója", 7);

            //Ugy ugy1 = new Ugy("Ugy001", "Betörés", "Betörés egy ékszerboltba", "folyamatban");
            //Ugy ugy2 = new Ugy("Ugy002", "Csalás", "Online csalás egy bank ellen", "lezárt");
            //Ugy ugy3 = new Ugy("Ugy003", "Kihágás", "Közlekedési kihágás vizsgálata", "folyamatban");

            ////Szemely szemely1 = new Szemely("Kiss János", 35, "Korábbi bűncselekmények");
            ////Szemely szemely2 = new Szemely("Szabó Éva", 28, "Nincs előélete");
            ////Szemely szemely3 = new Szemely("Németh Péter", 42, "tanu");

            //Gyanusitott gyanusitott1 = new Gyanusitott("Lajcsika", 4,5,"megfigyelt");
            //Gyanusitott gyanusitott2 = new Gyanusitott("Lajos",32, 2,"szabad");

            //Tanu tanu1 = new Tanu("Németh Péter", 42);
            //tanu1.VallomasFelvetel( "Láttam a gyanúsítottat a helyszínen");
            //Idovonal_esemeny esemeny1 = new Idovonal_esemeny("2024-01-15", "Bizonyíték gyűjtése a helyszínen");
            //Idovonal_esemeny esemeny2 = new Idovonal_esemeny("2024-02-10", "Tanúvallomás rögzítése");

            //ugy1.Erintettek_hozzaadasa(gyanusitott1);
            
            //adattar.Ugyek.Add(ugy1);



            //ugy1.allapotvaltosztatas();
            //foreach (var bizonyitek in ugy1.Ugy_bizonyitekok)
            //{
            //    Console.WriteLine($"Bizonyíték azonosító: {bizonyitek.Azonosito}, típus: {bizonyitek.Tipus}, leírás: {bizonyitek.Leiras}, megbízhatósági érték: {bizonyitek.Megbizhatosagi_etek}");
            //}
            //ugy1.Bizonyitek_hozzaadasa_egyesevel();
            //foreach (var bizonyitek in ugy1.Ugy_bizonyitekok)
            //{
            //    Console.WriteLine($"Bizonyíték azonosító: {bizonyitek.Azonosito}, típus: {bizonyitek.Tipus}, leírás: {bizonyitek.Leiras}, megbízhatósági érték: {bizonyitek.Megbizhatosagi_etek}");
            //}

        }
    }
}

namespace Digitalis_nyomozoiroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo felhasznalo1 = new Felhasznalo("Kovács", "1233234CĐ", "nyomozó");
            Felhasznalo felhasznalo2 = new Felhasznalo("Nagy", "9876543AĐ", "adminisztrátor");
            Felhasznalo felhasznalo3 = new Felhasznalo("Tóth", "4567890BĐ", "elemző");

            Bizonyitek bizonyitek1 = new Bizonyitek("1232fvfm", "Fizikai", "Ujjlenyomat a helyszínről", 9);
            Bizonyitek bizonyitek2 = new Bizonyitek("9876ghgh", "Digitális", "E-mailek a gyanúsítottról", 8);
            Bizonyitek bizonyitek3 = new Bizonyitek("4567jklj", "Tanúvallomás", "Szemtanú beszámolója", 7);

            Ugy ugy1 = new Ugy("Ugy001", "Betörés", "Betörés egy ékszerboltba", "folyamatban");
            Ugy ugy2 = new Ugy("Ugy002", "Csalás", "Online csalás egy bank ellen", "lezárt");
            Ugy ugy3 = new Ugy("Ugy003", "Kihágás", "Közlekedési kihágás vizsgálata", "folyamatban");

            Szemely szemely1 = new Szemely("Kiss János", 35, "Korábbi bűncselekmények");
            Szemely szemely2 = new Szemely("Szabó Éva", 28, "Nincs előélete");
            Szemely szemely3 = new Szemely("Németh Péter", 42, "tanu");

            Gyanusitott gyanusitott1 = new Gyanusitott(szemely1,4,"megfigyelt");
            Gyanusitott gyanusitott2 = new Gyanusitott(szemely2,2,"szabad");

            Tanu tanu1 = new Tanu(szemely3,"pozitiv","Látta a tettest a helyszínen");

            Idovonal_esemeny esemeny1 = new Idovonal_esemeny("2024-01-15", "Bizonyíték gyűjtése a helyszínen");
            Idovonal_esemeny esemeny2 = new Idovonal_esemeny("2024-02-10", "Tanúvallomás rögzítése");

            
            ugy1.Ugy_erintettek = new List<Szemely> { szemely1, szemely2 };
            ugy1.Ugy_bizonyitekok = new List<Bizonyitek> { bizonyitek1, bizonyitek2 };
            ugy1.allapotvizsgalat();
            

        }
    }
}

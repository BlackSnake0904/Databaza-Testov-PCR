namespace Databaza_Testov_PCR;

public class Osoba
{
    public string Meno { get; set; }
    public string Priezvisko { get; set; }
    public DateTime DatumNarodenia { get; set; }
    public string RodneCislo { get; set; }

    public readonly List<PCR> ZoznamUrobenychTestov = new List<PCR>();

    public Osoba(string aMeno, string aPriezvisko, DateTime aDatumNarodenia, string aRodCislo)
    {
        Meno = aMeno;
        Priezvisko = aPriezvisko;
        DatumNarodenia = aDatumNarodenia;
        RodneCislo = aRodCislo;
    }

    public override string ToString()
    {
        return Meno + ", " + Priezvisko + ", " + DatumNarodenia + ", " + RodneCislo + "Pocet testov:" + ZoznamUrobenychTestov.Count;
    }
}
namespace Databaza_Testov_PCR;

public class PCR : IComparable<PCR>
{
    public DateTime DatumACas { get; set; }
    public string RodneCislo { get; set; }
    public string KodPCR { get; set; }
    public int KodPracoviska { get; set; }
    public int KodOkresu { get; set; }
    public int KodKraja { get; set; }
    public bool VysledokTestu { get; set; }
    public string Poznamka { get; set; }
    public Osoba osoba { get; set; }




    public PCR(DateTime aDatumACas, string aRodneCislo, string aKodPCR, int aKodPracoviska, int aKodOkresu, int aKodKraja, bool aVysledokTestu, string aPoznamka)
    {

        DatumACas = aDatumACas;
        RodneCislo = aRodneCislo;
        KodPCR = aKodPCR;
        KodPracoviska = aKodPracoviska;
        KodOkresu = aKodOkresu;
        KodKraja = aKodKraja;
        VysledokTestu = aVysledokTestu;
        Poznamka = aPoznamka;
        osoba = new Osoba(null, null, DateTime.MinValue, null);

    }

    public override string ToString()
    {
        return DatumACas + "," + RodneCislo + "," + KodPCR + ","
               + KodPracoviska + "," + KodOkresu + "," + KodKraja + "," + VysledokTestu + "," + Poznamka;
    }

    public int CompareTo(PCR other)
    {
        if (this.DatumACas > other.DatumACas)
        {
            return 1;
        }
        else if (this.DatumACas < other.DatumACas)
        {
            return -1;
        }
        else
        {
            return this.KodPCR.CompareTo(other.KodPCR);
        }
    }
}
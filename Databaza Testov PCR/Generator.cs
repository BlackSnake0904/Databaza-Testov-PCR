namespace Databaza_Testov_PCR;

class Generator
{
    private readonly List<string> _ListMien = new List<string> { "Paul", "Karol", "Kristian", "Tatiana", "Milan", "Zlatica", "Agnesa", "Stefan", "Bohdan", "Natalia", };

    private readonly List<string> _LiestPriezvisk = new List<string> {
        " Gibson", "Mckenzie", "Kerr", "Bombardo", "Graham", "Kennedy", "Huckle", "Walker", "Jones", "Hamilton",
        "Freling"
    };

    private int pomOkres;
    Random rand = new Random();

    public Osoba GenerujOsobu()
    {
        var meno = _LiestPriezvisk[rand.Next(0, _ListMien.Count)];
        var priezvisko = _LiestPriezvisk[rand.Next(0, _ListMien.Count)];
        DateTime datumNarodenia = new DateTime(rand.Next(1900, 2000), rand.Next(1, 12), rand.Next(1, 28));
        string rodCislo = null; //2233333333
        for (int i = 0; i < 10; i++)
        {
            rodCislo = rodCislo + rand.Next(0, 9);
        }

        return new Osoba(meno, priezvisko, datumNarodenia, rodCislo);

    }

    public PCR GenerujPCR()
    {
        DateTime DatumACas = new DateTime(rand.Next(2021, 2022), rand.Next(1, 13), rand.Next(1, 28), rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));

        string RodneCislo = Program.ListRodCisel[rand.Next(0, Program.ListRodCisel.Count)];
        Guid GenPCR = Guid.NewGuid();
        string KodPCR = GenPCR.ToString();
        int KodPracoviska = rand.Next(1, 10);

        int KodKraja = rand.Next(1, 10);

        if (KodKraja == 1) { pomOkres = rand.Next(100, 110); }
        if (KodKraja == 2) { pomOkres = rand.Next(200, 210); }
        if (KodKraja == 3) { pomOkres = rand.Next(300, 310); }
        if (KodKraja == 4) { pomOkres = rand.Next(400, 410); }
        if (KodKraja == 5) { pomOkres = rand.Next(500, 510); }
        if (KodKraja == 6) { pomOkres = rand.Next(600, 610); }
        if (KodKraja == 7) { pomOkres = rand.Next(700, 710); }
        if (KodKraja == 8) { pomOkres = rand.Next(800, 810); }
        if (KodKraja == 9) { pomOkres = rand.Next(900, 910); }


        int KodOkresu = pomOkres;
        bool VysledokTestu;
        if (rand.Next(0, 10) < 5) { VysledokTestu = false; } else { VysledokTestu = true; }
        string Poznamka = "note";




        return new PCR(DatumACas, RodneCislo, KodPCR, KodPracoviska, KodOkresu, KodKraja, VysledokTestu, Poznamka);
    }
}
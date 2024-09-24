using System.Runtime.CompilerServices;

namespace Databaza_Testov_PCR
{
    internal class Program
    {
        public static List<string> ListRodCisel { get; set; } = new List<string>();
        

        static void Main(string[] args)
        {
            int pocetGenerovanychPacientov = 5;
            int pocetGenerovanychTestov = 1;


            var generator = new Generator();
            List<Osoba> zoznamPacientov = new List<Osoba>();

            

            for (int i = 0; i < pocetGenerovanychPacientov; i++)
            {
                zoznamPacientov.Add(generator.GenerujOsobu());
                ListRodCisel.Add(zoznamPacientov[^1].RodneCislo);
            }

            Console.WriteLine("Vygenerovane Testy");
            for (int i = 0; i < pocetGenerovanychTestov; i++)
            {
                var testPCR = generator.GenerujPCR();
                var indexOsoby =zoznamPacientov.Find(x => x.RodneCislo.Contains(testPCR.RodneCislo));
               
                indexOsoby.ZoznamUrobenychTestov.Add(testPCR);
                Console.WriteLine(testPCR.ToString());

            }

            Console.WriteLine("Vsetky Testy v Systeme");
            foreach (var osoba in zoznamPacientov)
            {
                Console.WriteLine(osoba.ToString());
                foreach (var test in osoba.ZoznamUrobenychTestov)
                {
                    Console.WriteLine(test.ToString());
                }

                Console.WriteLine(" ");
            }
            

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Naidis_Ivanov_Nikita
{
    public class StartPage
    {
        public static void Main(string[] args)
        {

            List<Inimene> inimesed = new List<Inimene>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Mis on sinu nimi on?");
                string nimi = Console.ReadLine();
                Console.WriteLine($"Mis on {i+1}.Inimese vanus?");
                int vanus = int.Parse(Console.ReadLine());
                
            }
            //var analüüs = Funktsioonid.Statistika(inimesed);
            //Console.WriteLine($"Vanuste arv: {analüüs.Item1}");
            //Console.WriteLine($"Vanuste keskmine: {analüüs.Item2}");
            //Console.WriteLine($"Noorim inimene: {analüüs.Item3} ");
            //Console.WriteLine($"Vanem inimene: {analüüs.Item4}");

            //8 ül
            string[] opilased = { "Anna", "Peter", "Markus", "Artur", "Mati", "Alina" };
            Funktsioonid.Õpilastegamängimine(opilased);
            
            
            //Inimene inimene1 = new Inimene("Nimi", 144);
            //inimesed.Add(inimene1);

            //
            //
            //Console.WriteLine("Mis on teise vanus?");
            //
            //Inimene inimene2 = new Inimene(nimi, vanus);
            //inimesed.Add(inimene2);
            //List<Isik> inimesed = new List<Isik>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Sisesta nimi: ");
            //    string nimi = Console.ReadLine();

            //    Console.Write("Sisesta vanus: ");
            //    int vanus = int.Parse(Console.ReadLine());

            //    Isik uusIsik = new Isik();
            //    uusIsik.Nimi = nimi;
            //    uusIsik.Vanus = vanus;

            //    inimesed.Add(uusIsik);
            //}

            //Console.WriteLine("\nKõik inimesed tervitavad:\n");

            //foreach (Isik isik in inimesed)
            //{
            //    isik.Tervitus();
            //}





            int[] arvud = new int[5];
            Funktsioonid.Massiivide_kuvamine(arvud);

            //Küsi mis positsioonil muuda element ja mis väärtuseks, muuda element ja kuva massiiv

            //Funktsioonid.muudaelementmaasiivis(arvud);

            //3.Osa ülesanded
            int[] test = kolmosa.GenereeriRuudud(1, 11);
            Funktsioonid.Massiivide_kuvamine(test);

            //double[] arvud1 = Funktsioonid.TäidaMassiiv(new double[5]);
            //Funktsioonid.Massiivide_kuvamine(arvud1);
            //var tulemus = kolmosa.AnalüüsiArve();


            //Console.OutputEncoding = Encoding.UTF8;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("d");
            //string tekst = "gjfdsghfdjfs";

            //Random rnd = new Random();
            //int juhuslikarv = rnd.Next(-5, 32);
            //Console.WriteLine(Funktsioonid.Kuu_nimetus(juhuslikarv));
            //juhuslikarv = rnd.Next(-5, 32);
            //tekst = Funktsioonid.Kuu_nimetus(juhuslikarv);
            //Console.WriteLine(tekst);
            //Console.WriteLine("Mis on sinu nimi:");
            //string nimi = Console.ReadLine();

            ////Juku ja Kinno
            //Console.WriteLine(TeineOsa.Jukku);
            //Console.WriteLine(TeineOsa.Jukku(nimi));
            //Console.WriteLine(TeineOsa.Jukku("Python"));





        }
    }

}

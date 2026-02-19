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

            bool tööta = true;

            while (tööta)
            {
                Console.Clear();
                Console.WriteLine("========== PEAMENÜÜ ==========");
                Console.WriteLine("1.  Pinginaabrid");
                Console.WriteLine("2.  Toa pindala");
                Console.WriteLine("3.  Temperatuur");
                Console.WriteLine("4.  Pikkus");
                Console.WriteLine("5.  Pikkus ja sugu");
                Console.WriteLine("6.  Kalkulaator");
                Console.WriteLine("7.  Hooaeg");
                Console.WriteLine("8.  Kuu nimetus");
                Console.WriteLine("9.  Massiivide kuvamine");
                Console.WriteLine("10. Muuda element massivis");
                Console.WriteLine("11. Genereeri korrutustabel");
                Console.WriteLine("12. Genereeri ruudud");
                Console.WriteLine("13. Ostud");
                Console.WriteLine("0.  Välju");
                Console.WriteLine("==============================");
                Console.Write("Vali number: ");

                string valik = Console.ReadLine();

                Console.WriteLine();

                switch (valik)
                {
                    case "1":
                        TeineOsa.Pinginaabrid();
                        break;

                    case "2":
                        TeineOsa.Toa();
                        break;

                    case "3":
                        TeineOsa.temperatuur();
                        break;

                    case "4":
                        TeineOsa.Pikkus();
                        break;

                    case "5":
                        TeineOsa.PikkjaSugu();
                        break;

                    case "6":
                        Console.Write("Sisesta esimene arv: ");
                        float arv1 = float.Parse(Console.ReadLine());
                        Console.Write("Sisesta teine arv: ");
                        float arv2 = float.Parse(Console.ReadLine());
                        float tulemus = Funktsioonid.Kalkulaator(arv1, arv2);
                        Console.WriteLine($"Tulemus: {tulemus}");
                        break;

                    case "7":
                        Console.Write("Sisesta kuu number (1-12): ");
                        int kuu = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Hooaeg: {Funktsioonid.Hooaeg(kuu)}");
                        break;

                    case "8":
                        Console.Write("Sisesta kuu number (1-12): ");
                        int kuuNr = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Kuu nimetus: {Funktsioonid.Kuu_nimetus(kuuNr)}");
                        break;

                    case "9":
                        int[] arvud2 = { 10, 20, 30, 40, 50 };
                        Funktsioonid.muudaelementmaasiivis(arvud2);
                        break;

                    case "11":
                        Console.Write("Sisesta ridade arv: ");
                        int read = int.Parse(Console.ReadLine());
                        Console.Write("Sisesta veergude arv: ");
                        int veerud = int.Parse(Console.ReadLine());
                        Funktsioonid.GenereeriKorrutustabel(read, veerud);
                        break;


                    case "12":
                        int[] ruudud = kolmosa.GenereeriRuudud(1, 11);
                        Funktsioonid.Massiivide_kuvamine(ruudud);
                        break;

                    case "13":
                        TeineOsa.Ostud();
                        break;

                    case "0":
                        tööta = false;
                        Console.WriteLine("Nägemist!");
                        break;

                    default:
                        Console.WriteLine("Vale valik! Proovi uuesti.");
                        break;
                }

                if (tööta)
                {
                    Console.WriteLine("\nVajuta ENTER et menüüsse tagasi minna...");
                    Console.ReadLine();
                }
                List<Inimene> inimesed = new List<Inimene>();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Mis on sinu nimi on?");
                    string nimi = Console.ReadLine();
                    Console.WriteLine($"Mis on {i + 1}.Inimese vanus?");
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
                //4 ül
                string märksõna = "jah";
                string fraas = "Osta elevant ära!";
                Funktsioonid.KuniMärksõnani(märksõna, fraas);

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

}

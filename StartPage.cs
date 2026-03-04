using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine("--- Teine osa ---");
                Console.WriteLine("1.  Pinginaabrid");
                Console.WriteLine("2.  Toa pindala ja remont");
                Console.WriteLine("3.  Temperatuur");
                Console.WriteLine("4.  Pikkus");
                Console.WriteLine("5.  Pikkus ja sugu");
                Console.WriteLine("6.  Poes ostlemine");
                Console.WriteLine("--- Kolmas osa ---");
                Console.WriteLine("7.  Juhuslike arvude ruudud");
                Console.WriteLine("8.  Viie arvu analüüs");
                Console.WriteLine("9.  Korrutustabel");
                Console.WriteLine("10. Õpilastega mängimine");
                Console.WriteLine("11. Kuni märksõnani");
                Console.WriteLine("12. Inimeste statistika");
                Console.WriteLine("13. Positiivsed ja negatiivsed");
                Console.WriteLine("--- Neljas osa ---");
                Console.WriteLine("14. Failitöötlus");
                Console.WriteLine("15. Faili lugemine");
                Console.WriteLine("16. Ridade lugemine");
                Console.WriteLine("17. Ridade lugemine Listiks");
                Console.WriteLine("------------------------------");
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
                        TeineOsa.Ostud();
                        break;
                    case "7":
                        int[] ruudud = kolmosa.GenereeriRuudud(1, 11);
                        Funktsioonid.Massiivide_kuvamine(ruudud);
                        break;
                    case "8":
                        double[] arvud = new double[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Sisesta {i + 1}. arv: ");
                            arvud[i] = double.Parse(Console.ReadLine());
                        }
                        var tulemus = kolmosa.AnalüüsiArve(arvud);
                        Console.WriteLine($"Summa: {tulemus.Item1:F2}");
                        Console.WriteLine($"Keskmine: {tulemus.Item2:F2}");
                        Console.WriteLine($"Korrutis: {tulemus.Item3:F2}");
                        break;
                    case "9":
                        Console.Write("Sisesta ridade arv: ");
                        int read = int.Parse(Console.ReadLine());
                        Console.Write("Sisesta veergude arv: ");
                        int veerud = int.Parse(Console.ReadLine());
                        Funktsioonid.GenereeriKorrutustabel(read, veerud);
                        break;
                    case "10":
                        string[] opilased = { "Anna", "Peter", "Markus", "Artur", "Mati", "Alina" };
                        Funktsioonid.Õpilastegamängimine(opilased);
                        break;
                    case "11":
                        string märksõna = "";
                        Funktsioonid.KuniMärksõnani(märksõna, "Osta elevant ära!");
                        break;
                    case "12":

                        List<Inimene> inimesed2 = new List<Inimene>();
                        for (int i = 0; i < 5; i++)
                        {
                            
                            Console.WriteLine($"Mis on {i + 1}. Nimi?:  ");
                            string nimi = Console.ReadLine();
                            Console.WriteLine($"Mis on {i + 1}. Inimese vanus?:  ");
                            int vanus = int.Parse(Console.ReadLine());
                            Inimene inimene = new Inimene(nimi, vanus);
                            inimesed2.Add(inimene);

                        }
                        kolmosa.Statistika(inimesed2);
                        var inimese = kolmosa.Statistika(inimesed2);
                        Console.WriteLine($"Summa: {inimese.Item1}");
                        Console.WriteLine($"Keskmine: {inimese.Item2}");
                        Console.WriteLine($"Vanem inimene: {inimese.Item3.Nimi}");
                        Console.WriteLine($"Noorem inimene: {inimese.Item4.Nimi}");
                        break;
                    case "13":
                        kolmosa.PositiivsedjaNegatiivsed();
                        break;
                    case "14":
                        Osa4.failitöötlus();
                        break;
                    case "15":
                        Osa4.Faililugemine();
                        break;
                    case "16":
                        Osa4.Ridadelugemine();
                        break;
                    case "17":
                        Console.WriteLine("failinimi");
                        string fail = Console.ReadLine();
                        Osa4.Ridadelugemine_listiks(fail);
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
            }
        }
    }
}
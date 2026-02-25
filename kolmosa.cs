using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_Ivanov_Nikita
{
    public class kolmosa
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rand = new Random();
            

            int n = rand.Next(min, max + 1);
            int m = rand.Next(min, max + 1);

            int start = Math.Min(n, m);
            int end = Math.Max(n, m);
            Console.WriteLine($"{start}, {end}, {end - start}");
            int[] masiiv = new int[end - start];
            for (int i = start; i < end; i++)
            {
                
                masiiv[i-start] = i*i;
            }
            return masiiv;

        }
        public static Tuple<double,double,double> AnalüüsiArve(double[] arvud1)
        {
            double summa = arvud1.Sum();
            double keskmine = arvud1.Average();
            double korrutis = 1;
            foreach (double arv in arvud1)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = inimesed.Sum(i => i.Vanus);
            double keskmine = inimesed.Average(i => i.Vanus);
            Inimene vanem = inimesed.OrderByDescending(i => i.Vanus).First();
            Inimene noorem = inimesed.OrderBy(i => i.Vanus).First();
            return Tuple.Create(summa, keskmine, vanem, noorem);
        }
        public static void KuniMärksõnani(string märksõna, string fraas)
        {
            do
            {
                Console.WriteLine(fraas);
                märksõna = Console.ReadLine();
            } while (märksõna != "jah");
        }
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (j + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            return tabel;
        }
        public static void Õpilastegamängimine(string[] nimed)
        {
            Console.WriteLine("Uus nimi:");
            string nimi1 = Console.ReadLine();
            nimed[2] = nimi1;
            nimed[5] = "Mati";
            int i = 0;
            while (i > nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                    Console.WriteLine($"Tere, {nimed[i]}!");
                i++;
            }
            for (int j = 0; j < nimed.Length; j++)
                Console.WriteLine($"indeks: {j},Nimi: {nimed[j]}");
            foreach (string nimi in nimed)
                Console.WriteLine(nimi.ToLower());
            i = 0;
            do
            {
                if (nimed[i] == "Mati")
                {
                    Console.WriteLine("Leidsin Mati!");
                    break;
                }
                Console.WriteLine($"Tere,{nimed[i]}");
                i++;
            } while (i < nimed.Length);

            
            


        }
        public static void PositiivsedjaNegatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            int positiivseid = 0;
            int negatiivseid = 0;
            int nulle = 0;

            foreach (int arv in arvud)
            {
                if (arv>0)
                {
                    positiivseid++;
                }
                else if (arv<0)
                {
                    negatiivseid++;
                }
                else
                {
                    nulle++;
                }
            }
            Console.WriteLine($"Positiivseid: {positiivseid}");
            Console.WriteLine($"Negatiivseid: {negatiivseid}");
            Console.WriteLine($"Nulle: {nulle}");
        }
    }

}

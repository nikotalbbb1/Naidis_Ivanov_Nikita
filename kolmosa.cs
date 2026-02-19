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
        //public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        //{
        //    int summa = inimesed.Sum(i => i.Vanus);
        //    double keskmine = inimesed.Average(i => i.Vanus);
        //    Inimene vanem = inimesed.OrderByDescending(i => i.Vanus).First();
        //    Inimene noorem = inimesed.OrderBy(i => i.Vanus).First();
        //    return Tuple.Create(summa, keskmine, vanem, noorem);





        //}
    }

}

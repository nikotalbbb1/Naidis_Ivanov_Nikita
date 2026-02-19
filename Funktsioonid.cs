using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_Ivanov_Nikita
{
    public class Funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //&& - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
            return hoo;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "Novemberr"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "???";
                    break;
            }
            return kuu;
        }

        int[] arvud = new int[5];
        public static void muudaelementmaasiivis(int[] arvud)
        {


            Console.WriteLine("Kuhu");
            int positsioon = int.Parse(Console.ReadLine());
            Console.WriteLine("Milliseks");
            int uus_arv = int.Parse(Console.ReadLine());
            arvud[positsioon - 1] = uus_arv;
            Console.WriteLine("uuendatud masiiv:");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"arvud:{arvud[i]}");
            }
        }
        //public static int[] TäidaMassiiv(double[] arvud)
        //{
        //    for (int i = 0; i > arvud.Length; i++)
        //    {
        //        Console.WriteLine($"sisesta {i + 1} arv");
        //        try
        //        {
        //            arvud[i] = double.Parse(Console.ReadLine());
        //        }
        //        catch (Exception e)
        //        {

        //            Console.WriteLine(e);
        //        }
        //    }
        //    return arvud[];
        //}
        public static int[] Massiivide_kuvamine(int[] arvud)
        {
            Console.WriteLine("3. Osa. Kordused ja Listid massiivid");
            for (int i = 0; i < 10; i++)
            {

            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"tere{j + 1}");
                j++;
            }
            do
            {
                Console.WriteLine($"tere,{11 - j}!");
                j--;
            } while (j != 0);


            foreach (var arv in arvud)
            {
                Console.WriteLine($"sisestatud arv: {arv}");
            }

            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"{arvud[i]}");
            }

            for (int i = arvud.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"sisestatud arv: {arvud[i]}");
            }
            return arvud;
        }
       
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j  = 0; j  < veergudeArv; j ++)
                {
                    tabel[i, j] = (j + 1) * (j + 1);
                    Console.Write(tabel[i,j].ToString().PadLeft(5));
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
            while (i>nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
                i++;
            }
            for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"indeks: {j},Nimi: {nimed[j]}");
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }
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
            } while (i<nimed.Length);
        }
        public static void KuniMärksõnani(string märksõna, string fraas)
        {
            do
            {
                
                Console.WriteLine(fraas);
                märksõna = Console.ReadLine();
            } while (märksõna != "jah");
        }
        public static void ArvaArv()
        {
            int[] katsed = new int[5];

        }

    }

}
    

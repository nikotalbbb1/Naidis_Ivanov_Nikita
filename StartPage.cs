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





            //int[] arvud = new int[5];
            //Funktsioonid.Massiivide_kuvamine(arvud);

            //Küsi mis positsioonil muuda element ja mis väärtuseks, muuda element ja kuva massiiv

            //Funktsioonid.muudaelementmaasiivis(arvud);

            //3.Osa
            int[] test = kolmosa.GenereeriRuudud(1, 11);
            Funktsioonid.Massiivide_kuvamine(test);

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

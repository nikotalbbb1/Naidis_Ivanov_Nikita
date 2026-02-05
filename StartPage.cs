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
            Console.WriteLine("Mis on sinu nimi:");
            string nimi = Console.ReadLine();

            //Juku ja Kinno
            Console.WriteLine(TeineOsa.Jukku);
            Console.WriteLine(TeineOsa.Jukku(nimi));
            Console.WriteLine(TeineOsa.Jukku("Python"));





        }
    }

}

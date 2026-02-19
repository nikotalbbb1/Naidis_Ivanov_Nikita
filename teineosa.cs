using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Naidis_Ivanov_Nikita
{
    public class TeineOsa
    {
        public static void Pinginaabrid()
        {
            Console.Write("Sisesta esimese inimese nimi: ");
            string nimi1 = Console.ReadLine();

            Console.Write("Sisesta teise inimese nimi: ");
            string nimi2 = Console.ReadLine();

            Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid!");
        }

        public static void Toa()
        {
            Console.WriteLine("Mis on sinu toa pikkus?");
            int vastus1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis on sinu toa laius?");
            int vastus2 = int.Parse(Console.ReadLine());
            int tulemus = vastus1 * vastus2;
            Console.WriteLine("Aga kas sa tahad remondi teha?");
            string vastus3 = Console.ReadLine();

            if (vastus3.ToLower() == "jah")
            {
                Console.WriteLine("Kui palju maksab 1 ruudumeeter?");
                double hind = double.Parse(Console.ReadLine());
                double kokkusumma = hind * tulemus;
                Console.WriteLine($"Sinu põranda vahetamise hind: {kokkusumma}");
                Console.WriteLine("Sul on ka soodustus on");
                double soodustus = kokkusumma * 0.70;
                Console.WriteLine($"Sinu soodustusega hind: {soodustus}");
            }
            else
            {
                Console.WriteLine($"Sinu toa pindala on {tulemus} ruutmeetrit");
            }
        }

        public static void temperatuur()
        {
            Console.WriteLine("Milline temperaatur on sinu toas?");
            int kasutajavastus = int.Parse(Console.ReadLine());
            if (kasutajavastus > 18)
            {
                Console.WriteLine("See on üle kaheksateistkümne kraadi (soovitav toasoojus talvel)");
            }
            else
            {
                Console.WriteLine("Selge");
            }
        }

        public static void Pikkus()
        {
            Console.WriteLine("Kui pikk sa oled santimeetrites?");
            int pikkus = int.Parse(Console.ReadLine());
            if (pikkus > 150 && pikkus <= 175)
            {
                Console.WriteLine("Sa oled keskmine");
            }
            else if (pikkus > 175 && pikkus <= 200)
            {
                Console.WriteLine("Sa oled pikk");
            }
            else
            {
                Console.WriteLine("Sa oled lühike");
            }
        }

        public static void PikkjaSugu()
        {
            Console.WriteLine("Tere, kas sa oled mees või naine?");
            string sugu = Console.ReadLine();

            if (sugu == "naine")
            {
                Console.WriteLine("Kui pikk sa oled santimeetrites?");
                int pikkus1 = int.Parse(Console.ReadLine());
                if (pikkus1 > 150 && pikkus1 <= 175)
                {
                    Console.WriteLine("Sa oled keskmine");
                }
                else if (pikkus1 > 175 && pikkus1 <= 200)
                {
                    Console.WriteLine("Sa oled pikk");
                }
                else
                {
                    Console.WriteLine("Sa oled lühike");
                }
            }
            else if (sugu == "mees")
            {
                Console.WriteLine("Kui pikk sa oled santimeetrites?");
                int pikkus2 = int.Parse(Console.ReadLine());
                if (pikkus2 > 150 && pikkus2 <= 175)
                {
                    Console.WriteLine("Sa oled keskmine");
                }
                else if (pikkus2 > 175 && pikkus2 <= 200)
                {
                    Console.WriteLine("Sa oled pikk");
                }
                else
                {
                    Console.WriteLine("Sa oled lühike");
                }
            }
        }

        public static void Ostud()
        {
            Console.WriteLine("Kas sa tahad osta piima?");
            string piim = Console.ReadLine();
            double piim_hind = 1.20;

            Console.WriteLine("Kas sa tahad osta saia?");
            string sai = Console.ReadLine();
            double sai_hind = 0.80;

            Console.WriteLine("Kas sa tahad osta leiba?");
            string leib = Console.ReadLine();
            double leib_hind = 0.80;

            double ostukorv = 0;
            if (piim == "jah") ostukorv += piim_hind;
            if (sai == "jah") ostukorv += sai_hind;
            if (leib == "jah") ostukorv += leib_hind;

            if (ostukorv > 0)
                Console.WriteLine($"Sinu ostukorv on {ostukorv} eurot");
            else
                Console.WriteLine("Sa ei ostnud midagi");
        }
    }
}
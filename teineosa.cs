using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Naidis_Ivanov_Nikita
{
    internal class TeineOsa
    {
        //public static string Jukku(string nimi)
        //{
        //    string otsus = "";
        //    string vastud = "";
        //    int vanus = 0;
        //    string pilet = "";
        //    Console.WriteLine("Tere palun sisesta oma nimi");
        //    nimi = Console.ReadLine();
        //    if (nimi.ToLower() == "jukku")
        //    {
        //        Console.WriteLine("Kui vana sa oled?");
        //        try
        //        {
        //            vanus = int.Parse(Console.ReadLine());
        //            if (vanus > 0 && vanus < 100)
        //            {
        //                if (vanus < 6)
        //                {
        //                    pilet = "Tasuta";
        //                }
        //                else if (vanus > 6 && vanus <= 14)
        //                {
        //                    pilet = "Lastepilet";
        //                }
        //                else if (vanus >= 14 && vanus < 65)
        //                {
        //                    pilet = "Täispilet";
        //                }
        //                else if (vanus >= 65)
        //                {
        //                    pilet = "Sooduspilet";
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Viga");
        //            }
        //        }
        //        catch (Exception e)
        //        {

        //            Console.WriteLine(e);
        //        }
        //        otsus = $"Lähme kinno + {pilet}";
        //    }
        //    return otsus;
        //}

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

            if (piim == "jah")
            {
                double ostukorv = piim_hind;
                if (sai == "jah")
                {
                     ostukorv = sai_hind+piim_hind;
                    if(leib == "jah")
                    {
                        ostukorv = leib_hind + sai_hind + piim_hind;
                        Console.WriteLine($"Sinu ostukorv on {ostukorv} eurot");
                    }
                    else
                    {
                        Console.WriteLine($"Sinu ostukorv on {ostukorv} eurot");
                    }
                }
            }
            else
            {
                if (sai == "jah")
                {
                    double ostukorv = sai_hind;
                    if (leib == "jah")
                    {
                        ostukorv = leib_hind + sai_hind;
                        Console.WriteLine($"Sinu ostukorv on {ostukorv} eurot");
                    }
                    else
                    {
                        Console.WriteLine($"Sinu ostukorv on {ostukorv} eurot");
                    }
                }
                else
                {
                    if (leib == "jah")
                    {
                        double ostukorv = leib_hind;
                    }
                    else
                    {
                        Console.WriteLine("Sa ei ostnud midagi");
                    }
                }





            }








        }






    }
}



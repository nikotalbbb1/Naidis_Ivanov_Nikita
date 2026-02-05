using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_Ivanov_Nikita
{
    internal class TeineOsa
    {
        public static string Jukku(string nimi)
        {
            string otsus = "";
            string vastud = "";
            int vanus = 0;
            string pilet = "";
            Console.WriteLine("Tere palun sisesta oma nimi");
            nimi = Console.ReadLine();
            if (nimi.ToLower() == "jukku")
            {
                Console.WriteLine("Kui vana sa oled?");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus < 100)
                    {
                        if (vanus < 6)
                        {
                            pilet = "Tasuta";
                        }
                        else if (vanus > 6 && vanus <= 14)
                        {
                            pilet = "Lastepilet";
                        }
                        else if (vanus >= 14 && vanus < 65)
                        {
                            pilet = "Täispilet";
                        }
                        else if (vanus >= 65)
                        {
                            pilet = "Sooduspilet";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Viga");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                otsus = $"Lähme kinno + {pilet}";
            }
            return otsus;
        }
            
        
    }
}

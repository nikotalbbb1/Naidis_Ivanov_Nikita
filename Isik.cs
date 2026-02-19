using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_Ivanov_Nikita
{
    public class Isik
    {
        public string Nimi;
        public int Vanus;

        public Isik(string nimi, int vanus)
        {
            Nimi = nimi;
           Vanus = vanus;
        }
        public Isik()
        { }
        public void Tervitus()
        {
            Console.WriteLine($"Tere {Nimi}, {Vanus}");
        }
    }


}

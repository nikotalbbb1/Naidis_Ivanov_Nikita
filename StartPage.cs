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
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("d");
            
            try
            {
                Console.WriteLine("Arv1:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Arv 2:");
                float b = float.Parse(Console.ReadLine());
                float vastus = Funktsioonid.Kalkulaator(a,b);
                Console.WriteLine(vastus);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }

}

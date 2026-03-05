using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Naidis_Ivanov_Nikita
{
    public class Osa4
    {
        public static void failitöötlus()
        {
            try
            {
                string path = @"..\..\..\Kuud.txt"; //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }

        }
        public static void  Faililugemine()
        {
            try
            {
                string path = @"..\..\..\Kuud.txt";
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static void Ridadelugemine()
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = @"..\..\..\Kuud.txt";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                foreach (string item in kuude_list)
                {
                    Console.WriteLine(item);
                }
                

            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }
        public static List<string> Ridadelugemine_listiks(string file)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                

            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            return kuude_list;
        }
        public static void Lemmiktoit()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamWriter text = new StreamWriter(path, true);
                Console.WriteLine("Sisesta ühte Itaalia toidu nime:");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Mingi viga failiga");
            }
            
        }
        public static void KoguMenu()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {

                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static List<string> Koostisosade_muutmine()
        {
            List<string> Koostisosad = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    Koostisosad.Add(rida);
                }
               
                
                if (Koostisosad.Count > 0)
                    Koostisosad[0] = "Kvaliteetne oliiviõli";
                
                Koostisosad.Remove("Ketšup");
                foreach (string item in Koostisosad)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga!");
            }
            return Koostisosad;
        }




    }

}

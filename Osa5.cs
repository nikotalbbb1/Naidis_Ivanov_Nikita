using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Naidis_Ivanov_Nikita
{
    public class Osa5
    {
        public static void Person1()
        {
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));
            nimed.Sort();
            Console.WriteLine(nimed);

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
         
                
            

        }
        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1} , Suund: {route.Item2}");
        }
        public static void List()
        {
            
            List<string> people = new List<string>() { "Kadi", "Mirje", "Liisa", "Aino", "Kadri", "Tõnis", "Märt", "Jaan", "Peeter", "Andres" };

            //add
            people.Add("Test");
            Console.WriteLine(people);
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }
            //addRange
            people.AddRange("t1", "t2");
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }
            //IndexOf
            people.IndexOf("Liisa");

            //Insert
            people.Insert(0, "test1");

            //remove
            people.Remove("Aino");
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }

            //Sort
            people.Sort((a, b) => a.Length.CompareTo(b.Length));

            foreach (string p in people)
            {
                Console.WriteLine(p);
            }

            //BinarySearch()
            int test = people.BinarySearch("Mirje");
            Console.WriteLine(test);

            //removeAt()
            people.RemoveAt(0);
            Console.WriteLine(people);
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }
            //FindIndex()
            int p1 = people.FindIndex(p => p == "Mirje");
            Console.WriteLine(p1);

        }
        public static void LinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(1);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
            loetelu.Remove(555);
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
            loetelu.AddBefore(loetelu.Find(555),1);
            loetelu.AddAfter(loetelu.Find(555), 1);
            foreach (int arv in loetelu)
                Console.WriteLine(arv);



        }
        public static void Dictionary()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            Console.WriteLine("pealinn");
            riigid[2] = "Eestimaa";
            riigid.Remove(3);

            //Contains
            bool eesti = riigid.ContainsKey(77);
            Console.WriteLine(eesti);
            
        }
        public static void Kalorite_kalkulaator()
        {
            List<Toode> toode = new List<Toode>();
            new Toode() { Nimi = "Õun", Kalorid = 52 };
            new Toode() { Nimi = "Banaan", Kalorid = 89 };
            new Toode() { Nimi = "Kanafilee", Kalorid = 165 };
            new Toode() { Nimi = "Riis", Kalorid = 130 };
            new Toode() { Nimi = "Muna", Kalorid = 155 };
            new Toode() { Nimi = "Piim", Kalorid = 42 };
            new Toode() { Nimi = "Leib", Kalorid = 265 };
            new Toode() { Nimi = "Juust", Kalorid = 350 };
            new Toode() { Nimi = "Jogurt", Kalorid = 59 };
            new Toode() { Nimi = "Lõhe", Kalorid = 208 };

            string path = @"..\..\..\Toode.txt";
            StreamReader text = new StreamReader(path);
            string laused = text.ReadToEnd();
            text.Close();
            Console.WriteLine(laused);

        }




    }
}

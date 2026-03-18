using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

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
            loetelu.Remove(555);
            

        }




    }
}

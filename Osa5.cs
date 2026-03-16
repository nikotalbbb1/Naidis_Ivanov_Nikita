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
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }
        public static void List()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void LinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);
            

        }



    }
}

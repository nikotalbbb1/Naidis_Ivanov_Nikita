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
            loetelu.AddBefore(loetelu.Find(555), 1);
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
            List<Toode> toode = new List<Toode>()
            {
              new Toode() { Nimi = "Õun", Kalorid = 52 },
              new Toode() { Nimi = "Banaan", Kalorid = 89 },
              new Toode() { Nimi = "Kanafilee", Kalorid = 165 },
              new Toode() { Nimi = "Riis", Kalorid = 130 },
              new Toode() { Nimi = "Muna", Kalorid = 155 },
              new Toode() { Nimi = "Piim", Kalorid = 42 },
              new Toode() { Nimi = "Leib", Kalorid = 265 },
              new Toode() { Nimi = "Juust", Kalorid = 350 },
              new Toode() { Nimi = "Jogurt", Kalorid = 59 },
              new Toode() { Nimi = "Lõhe", Kalorid = 208 }
            };

            string path = @"..\..\..\Toode.txt";


            StreamWriter writer = new StreamWriter(path);
            foreach (Toode t in toode)
            {
                writer.WriteLine(t.Nimi + ";" + t.Kalorid);
            }
            writer.Close();


            StreamReader text = new StreamReader(path);
            string laused = text.ReadToEnd();
            text.Close();
            // Вводим данные пользователя
            Inimene2 inimene = new Inimene2();

            Console.Write("Sisesta nimi: ");
            inimene.Nimi = Console.ReadLine();

            Console.Write("Sisesta vanus: ");
            inimene.Vanus = int.Parse(Console.ReadLine());

            Console.Write("Sisesta sugu (M/N): ");
            inimene.Sugu = Console.ReadLine().ToUpper();

            Console.Write("Sisesta pikkus (cm): ");
            inimene.Pikkus = int.Parse(Console.ReadLine());

            Console.Write("Sisesta kaal (kg): ");
            inimene.Kaal = int.Parse(Console.ReadLine());

            Console.WriteLine("\nVali aktiivsustase:");
            Console.WriteLine("1 - Istuv eluviis (vähe või üldse mitte liikumine)");
            Console.WriteLine("2 - Kerge aktiivsus (1-3 korda nädalas)");
            Console.WriteLine("3 - Mõõdukas aktiivsus (3-5 korda nädalas)");
            Console.WriteLine("4 - Kõrge aktiivsus (6-7 korda nädalas)");
            Console.WriteLine("5 - Väga kõrge aktiivsus (füüsiline töö)");
            Console.Write("Sisesta valik (1-5): ");
            inimene.Aktiivsustase = int.Parse(Console.ReadLine());

            // Расчёт BMR по формуле Харриса-Бенедикта
            double bmr;
            if (inimene.Sugu == "M")
            {
                // Мужчины
                bmr = 88.36 + (13.4 * inimene.Kaal) + (4.8 * inimene.Pikkus) - (5.7 * inimene.Vanus);
            }
            else
            {
                // Женщины
                bmr = 447.6 + (9.2 * inimene.Kaal) + (3.1 * inimene.Pikkus) - (4.3 * inimene.Vanus);
            }

            // Коэффициент активности
            int aktiivsusKordaja;
            switch (inimene.Aktiivsustase)
            {
                case 1: aktiivsusKordaja = 1; break;
                case 2: aktiivsusKordaja = 2; break;
                case 3: aktiivsusKordaja = 3; break;
                case 4: aktiivsusKordaja = 4; break;
                case 5: aktiivsusKordaja = 5; break;
                default: aktiivsusKordaja = 6; break;
            }

            double paevanePajadus = bmr * aktiivsusKordaja;

            Console.WriteLine($"\nTere, {inimene.Nimi}!");
            Console.WriteLine($"Sinu päevane energiavajadus on: {paevanePajadus:F0} kcal");
            Console.WriteLine("\nToidunimistu päevase energiavajaduse põhjal:");
            Console.WriteLine($"{"Toode",-15} {"Kalorid/100g",-15} {"Kogus päevas (g)",-15}");
            Console.WriteLine(new string('-', 45));

            foreach (Toode t in toode)
            {
                double kogus = (paevanePajadus / t.Kalorid) * 100;
                Console.WriteLine($"{t.Nimi,-15} {t.Kalorid,-15} {kogus:F0}");
            }
            
       



        }
        public static void Maakonnad_ja_pealinnad()
        {
            Dictionary<string, string> maakonad = new Dictionary<string, string>();
            maakonad.Add("Harjumaa", "Tallinn");
            maakonad.Add("Pärnumaa", "Pärnu");
            maakonad.Add("Tartumaa", "Tartu");
            maakonad.Add("Ida Virumaa", "Narva");
            Console.WriteLine("Palun sisesta pealinn");
            string otsi = Console.ReadLine();
            foreach (KeyValuePair<string, string> paar in maakonad)
            {
                if (paar.Value == otsi)
                {
                    Console.WriteLine("Maakond on: " + paar.Key);
                }
            }
            Console.WriteLine("Palun sisesta maakond");
            string otsi2 = Console.ReadLine();
            if (maakonad.ContainsKey(otsi2))
            {
                Console.WriteLine(maakonad[otsi2]);
            }
            else
            {
                Console.WriteLine("Maakonda ei leitud! Kas soovid lisada? (jah/ei)");
                string vastus = Console.ReadLine();

                if (vastus == "jah")
                {
                    Console.WriteLine("Sisesta pealinn:");
                    string uusPealinn = Console.ReadLine();

                    maakonad.Add (otsi2, uusPealinn);
                    Console.WriteLine("Lisatud!");
                }
            }
            Random juhuslik = new Random();

            List<string> võtmed = new List<string>(maakonad.Keys);
            int õiged = 0;
            int kokku = maakonad.Count;
            for (int i = 0; i < maakonad.Count; i++)
            {
                int index = juhuslik.Next(maakonad.Count);
                string juhuMaakond = võtmed[index];
                Console.WriteLine("Mis on " + juhuMaakond + " pealinn?");
                string vastus = Console.ReadLine();

                if (vastus == maakonad[juhuMaakond])
                {
                    Console.WriteLine("Õige!");
                    õiged++;
                }
                else
                {
                    Console.WriteLine("Vale! Õige vastus: " + maakonad[juhuMaakond]);
                }
            }
            Console.WriteLine("Tulemus: " + õiged + "/" + kokku);
            Console.WriteLine("Protsent: " + (double)õiged / kokku * 100);
        }
        public static void Õpilased_ja_hinnete_analüüs()
        {
            Dictionary<string, List<int>> opilased = new Dictionary<string, List<int>>();
            opilased.Add("Mati", new List<int> { 4, 5, 3, 4 });
            opilased.Add("Kati", new List<int> { 5, 5, 4, 5 });
            opilased.Add("Jüri", new List<int> { 3, 2, 4, 3 });
            string parimNimi = "";
            double parimKeskmine = 0;
            foreach (KeyValuePair<string, List<int>> õpilane in opilased)
            {
                double keskmine = õpilane.Value.Average();
                Console.WriteLine(õpilane.Key + " keskmine: " + keskmine);
                if (keskmine > parimKeskmine)
                {
                    parimKeskmine = keskmine;
                    parimNimi = õpilane.Key;
                    Console.WriteLine($"Parim õpilane: {parimNimi}" +  $"keskmisega: {parimKeskmine}");
                }
                var sorteeritud = opilased.OrderBy(x => x.Value.Average());
                foreach (KeyValuePair<string, List<int>> opilane in sorteeritud)
                {
                    Console.WriteLine(õpilane.Key +" - " + õpilane.Value.Average());
                }
            }
        }
    }
}


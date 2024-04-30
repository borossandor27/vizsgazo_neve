using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static List<Dolgozo> dolgozok = new List<Dolgozo>();
        static void Main(string[] args)
        {
            beolvasas();
            feladat01();
            feladat02();
            feladat03();
            feladat04();

            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladat04()
        {
            Console.WriteLine("4.feladat:");
            foreach (var item in dolgozok.FindAll(a => a.reszleg == "asztalosműhely"))
            {
                Console.WriteLine($"\t{item.nev}");
            }
        }

        private static void feladat03()
        {
            //--- hányan dolgoznak az egyes részlegeken
            Console.WriteLine("3. feladat:");
            foreach (var item in dolgozok.GroupBy(a => a.reszleg).Select(b => new { reszleg = b.Key, letszam = b.Count() }))
            {
                Console.WriteLine($"\t{item.reszleg}: {item.letszam}");
            }
        }

        private static void feladat02()
        {
            //-- a legmagasabb keresetű dolgozó nevét
            Console.WriteLine("2. feladat:");
            Dolgozo max = dolgozok.Find(a => a.ber == dolgozok.Max(b => b.ber));
            Console.WriteLine($"\t{max.nev} fizetése: {max.ber} Ft");
        }

        private static void feladat01()
        {
            Console.WriteLine("1. faladat:");
            Console.WriteLine($"\tA dolgozók száma: {dolgozok.Count} fő");
        }

        private static void beolvasas()
        {
            using (StreamReader sr = new StreamReader("dolgozok.csv"))
            {
                sr.ReadLine(); // --- fejléc nem kell
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Replace('"', ' ').Split(',');
                    Dolgozo dolgozo = new Dolgozo(line[0].Trim(), line[1].Trim(), line[2].Trim(), int.Parse(line[3].Trim()), int.Parse(line[4].Trim()));
                    dolgozok.Add(dolgozo);
                }
            }
        }
    }
}

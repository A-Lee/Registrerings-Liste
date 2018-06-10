using System;
using System.Collections.Generic;
using System.Text;
using Finally.Ansatte;
using Finally.Mennesker;

namespace Finally.OnlineShop
{
    class HovedSide
    {
        private static readonly List<Ordre> ordreListe = new List<Ordre>();
        private static readonly List<Ansatt> ansatte = new List<Ansatt>();
        public static void Main(string[] args)
        {
            Kunde nathan = new Kunde(new Mennesker.Person("Nathan","Drake"," Island",30,23232323), 0, KundeType.Standard);
            nathan.leggTilOrdre(new Ordre(150,2,"Pizza"));
            nathan.leggTilOrdre(new Ordre(40,1,"Coca Cola 1,5"));

            Console.WriteLine($"Total ordre:\n{nathan.printOrdre()}");

            Kokk chef = new Kokk(new Person("Chef", "Boyard", "Somewhere", 32, 24343434), 180);
            Servitor waitress = new Servitor(new Person("Sally", "The Waitress", "Nowhere", 31, 55534553), 180);
            Sjafor gta = new Sjafor(new Person("CJ", "Fool", "Grove Street", 28, 24343434), 200);

            ansatte.Add(chef);
            ansatte.Add(waitress);
            ansatte.Add(gta);

            Console.ReadKey();

            foreach(Ansatt ansatt in ansatte)
            {
                ansatt.utforjobb();
            }

            Console.ReadKey();
        }
    }
}

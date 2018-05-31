using System;
using Finally.Mennesker;


namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test av personliste
            PersonListe personListe = new PersonListe();

            //Test personer
            Person p1 = new Person("John","Doe", "Riverside Chapel", 27, 44223322);
            Person p2 = new Person("John", "Doe", "Riverside Chapel", 27, 44223322);
            Person p3 = new Person("Solid", "Snake", "Shadow Moses Island", 25, 14185);
            Person p4 = new Person("Nathan", "Drake", "Pirat`s Cove", 30, 1337);

            //Sjekker at det ikke legges til duplikater
            personListe.leggTil(p1);
            personListe.leggTil(p2);
            personListe.leggTil(p3);
            personListe.leggTil(p4);

            //Test av finnes funksjonen
            Console.WriteLine("Finnes Stian Eriksen: " + personListe.finnes("Stian", "Eriksen"));
            Console.WriteLine("Finnes Nathan Drake: " + personListe.finnes("Nathan","Drake"));

            Console.WriteLine(personListe.getPerson(0).getInfo());

            Console.WriteLine($"Antall i listen: {personListe.antall()}");

            //Test av slett funksjonen
            personListe.slett("Crash", "Bandicoot");
            personListe.slett("Nathan", "Drake");

            Console.WriteLine($"Antall i listen: {personListe.antall()}");
            Console.WriteLine("\n\n");
            Console.WriteLine(personListe.printListe());
            Console.ReadKey();

        }
    }
}

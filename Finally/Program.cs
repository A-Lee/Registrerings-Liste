using System;
using Finally.Mennesker;
using Finally.Basics;


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

            FilProgrammering fp = new FilProgrammering();
            fp.lagFilOgMappe();
            fp.sjekkBilderMappe();

            Console.ReadKey();

            Person pf1 = new Person("Nathan2", "Drake3", "Pirat`s Cove", 30, 1337);
            Person pf2 = new Person("Nathan3", "Drake3", "Pirat`s Cove", 30, 1337);
            Person pf3 = new Person("Nathan3", "Drake3", "Pirat`s Cove", 30, 1337);
            Person pf4 = new Person("Nathan4", "Drake4", "Pirat`s Cove", 30, 1337);

            personListe.leggTilFlere(pf1,pf2,pf3,pf4);

            Console.WriteLine($"Antall i listen: {personListe.antall()}");
            Console.WriteLine("\n\n");
            Console.WriteLine(personListe.printListe());
            Console.ReadKey();

            Calculator test = new Calculator();
            Console.WriteLine(test.add(4,5,6,7,32,6,7));
            Console.WriteLine(test.multiply(5,3,5));

            Console.ReadKey();

            Kunde kunde = new Kunde(pf1, 1, KundeType.Standard);
            Ordre ordre1 = new Ordre(120, 4,"Stol");
            Ordre ordre2 = new Ordre(300, 1, "Bord");
            Ordre ordre3 = new Ordre(100, 2, "Lampe");

            kunde.leggTilOrdre(ordre1,ordre2,ordre3);

            kunde.printOrdre();

            Console.ReadKey();



        }
    }
}

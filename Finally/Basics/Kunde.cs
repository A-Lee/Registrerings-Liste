using System;
using System.Collections.Generic;
using System.Text;
using Finally.Mennesker;

namespace Finally.Basics
{
    class Kunde : Person
    {
        private int id;
        private KundeType kundeType;
        private readonly List<Ordre> ordreListe = new List<Ordre>();

        public Kunde(Person person, int id, KundeType kundeType)
            : base(person.getFornavn(), person.getEtternavn(), person.getAdresse(), person.getTelefon(), person.getTelefon())
        {
            this.id = id;
            this.kundeType = kundeType;
        }
        public KundeType getKundeType()
        {
            return kundeType;
        }
        public int getID()
        {
            return id;
        }
        public string getKundeInfo()
        {
            return this.getInfo() + "\nKundeType: " + getKundeType();
        }
        public void leggTilOrdre(Ordre ordre)
        {
            if(!gyldigOrdre(ordre))
            {
                Console.WriteLine("Ugyldig ordre");
            }
            else
            {
                ordreListe.Add(ordre);
                Console.WriteLine("Ordre lagt til");
            }
        }
        public void leggTilOrdre(params Ordre[] ordre)
        {
            bool gyldig = true;
            foreach(var o in ordre)
            {
                if(!gyldigOrdre(o))
                {
                    gyldig = false;
                    break;
                }
            }
            if(!gyldig)
            {
                Console.WriteLine("Feil med en av ordrene");
            }
            else if(ordre.Length < 1)
            {
                Console.WriteLine("Tom ordreliste sendt som parameter");
            }
            else
            {
                ordreListe.AddRange(ordre);
            }
        }
        public void printOrdre()
        {
            double sum = 0;
            string ordre = "";
            for(int i = 0; i < ordreListe.Count; i++)
            {
                sum += ordreListe[i].getSum();
                ordre += $"Artikkelnavn: {ordreListe[i].getBeskrivelse()} \tPris: {ordreListe[i].getSumForEn()}\tAntall: {ordreListe[i].getAntall()} \n";
            }
            ordre += $"\nTotal sum for ordre: {sum}";
            Console.WriteLine(ordre);
            
        }

        public bool gyldigOrdre(Ordre ordre)
        {
            if(ordre == null)
            {
                return false;
            }
            return true;
        }

    }
}

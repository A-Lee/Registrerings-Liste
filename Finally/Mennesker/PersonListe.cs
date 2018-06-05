using System;
using System.Collections.Generic;
using System.Text;

namespace Finally.Mennesker
{
    class PersonListe
    {
        private List<Person> personListe;

        public PersonListe()
        {
            personListe = new List<Person>();
        }
        public void leggTilFlere(params Person[] personer)
        {
            foreach(var person in personer)
            {
                if(finnes(person))
                {
                    Console.WriteLine($"{person.getFornavn()} finnes allerede i listen");
                    continue;
                }
                else
                {
                    personListe.Add(person);
                    Console.WriteLine($"{person.getFornavn()} {person.getEtternavn()} er lagt til i listen");
                }
            }
        }
        public void leggTil(Person p)
        {
            if(finnes(p))
            {
                Console.WriteLine("Personen finnes allerede i listen");
            }
            else
            {
                personListe.Add(p);
                Console.WriteLine($"{p.getFornavn()} {p.getEtternavn()} er lagt til i listen");
            }
        }
        public void slett(string fornavn, string etternavn)
        {
            if(!finnes(fornavn,etternavn))
            {
                Console.WriteLine("Personen finnes ikke i listen");
            }
            else
            {
                personListe.RemoveAt(getIndex(fornavn, etternavn));
                Console.WriteLine("Person slettet fra lista");
            }
        }
        public bool finnes(Person p)
        {
            foreach(Person person in personListe)
            {
                if(person.getFornavn().ToUpper().Equals(p.getFornavn().ToUpper()) 
                    && person.getEtternavn().ToUpper().Equals(p.getEtternavn().ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        public bool finnes(string fornavn, string etternavn)
        {
            foreach (Person person in personListe)
            {
                if (person.getFornavn().ToUpper().Equals(fornavn.ToUpper())
                    && person.getEtternavn().ToUpper().Equals(etternavn.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        public int getIndex(string fornavn, string etternavn)
        {
            int index = -1;
            for(int i = 0; i < personListe.Count;i++)
            {
                if(personListe[i].getFornavn().ToUpper().Equals(fornavn.ToUpper())
                    && personListe[i].getEtternavn().ToUpper().Equals(etternavn.ToUpper()))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public Person getPerson(int index)
        {
            if(index < 0 || index > personListe.Count)
            {
                Console.WriteLine("Ugyldig index oppgitt");
                return null;
            }
            else
            {
                return personListe[index];
            }
        }
        public int antall()
        {
            return personListe.Count;
        }
        public string printListe()
        {
            string utskrift = "";
            foreach(Person p in personListe)
            {
                utskrift += $"{p.getInfo()}\n\n";
            }

            return utskrift;
        }
    }
}

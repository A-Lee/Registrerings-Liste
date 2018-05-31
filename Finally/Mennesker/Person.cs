using System;
using System.Collections.Generic;
using System.Text;

namespace Finally.Mennesker
{
    class Person
    {
        private string fornavn, etternavn, adresse;
        private int alder, telefon;
        private DateTime registrert;
        
        public Person(string fornavn, string etternavn, string adresse,int alder, int telefon)
        {
            this.fornavn = fornavn;
            this.etternavn = etternavn;
            this.adresse = adresse;
            this.alder = alder;
            this.telefon = telefon;
            registrert = DateTime.Now;
        }

        public string getFornavn()
        {
            return fornavn;
        }
        public string getEtternavn()
        {
            return etternavn;
        }
        public string getAdresse()
        {
            return adresse;
        }
        public int getAlder()
        {
            return alder;
        }
        public int getTelefon()
        {
            return telefon;
        }

        public string getInfo()
        {
            string info = $"Fornavn: {getFornavn()}\nEtternavn: {getEtternavn()}\nAdresse: {getAdresse()}" +
                $"\nAlder: {getAlder()}\nTelefon: {getTelefon()}\nRegistrert: {registrert.ToLongDateString()} {registrert.ToLongTimeString()}";
            return info;
        }


    }
}

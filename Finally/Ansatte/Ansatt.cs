using System;
using System.Collections.Generic;
using System.Text;
using Finally.Mennesker;

namespace Finally.Ansatte
{
    class Ansatt : Person
    {
        private double timelonn;
        private readonly double antallTimer;
        public Ansatt(Person person, int timelonn)
            :base(person.getFornavn(),person.getEtternavn(),person.getAdresse(), person.getAlder(), person.getTelefon())
        {
            antallTimer = 0;
            this.timelonn = timelonn;
        }
        public virtual void utforjobb()
        {

        }
    }
}

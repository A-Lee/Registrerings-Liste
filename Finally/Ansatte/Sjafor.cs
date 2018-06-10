using System;
using System.Collections.Generic;
using System.Text;
using Finally.Mennesker;

namespace Finally.Ansatte
{
    class Sjafor : Ansatt
    {
        public Sjafor(Person person, int lonn)
            : base(person, lonn)
        {

        }
        public override void utforjobb()
        {
            Console.WriteLine("Kjører mat ut til kunder");
        }
    }
}

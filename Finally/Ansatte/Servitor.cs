using System;
using System.Collections.Generic;
using System.Text;
using Finally.Mennesker;

namespace Finally.Ansatte
{
    class Servitor : Ansatt
    {
        public Servitor(Person person, int lonn)
            : base(person, lonn)
        {

        }
        public override void utforjobb()
        {
            Console.WriteLine("Tar imot bestillinger fra kunder");
        }
    }
}

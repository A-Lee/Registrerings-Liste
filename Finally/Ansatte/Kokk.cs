using System;
using System.Collections.Generic;
using System.Text;
using Finally.Mennesker;

namespace Finally.Ansatte
{
    class Kokk : Ansatt
    {
        public Kokk(Person person, int lonn)
            :base(person, lonn)
        {

        }
        public override void utforjobb()
        {
            Console.WriteLine("Starter å lage mat");
        }
    }
}

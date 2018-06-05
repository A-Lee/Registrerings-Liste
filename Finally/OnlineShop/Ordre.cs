using System;
using System.Collections.Generic;
using System.Text;

namespace Finally.Basics
{
   
    class Ordre
    {
        private double sum;
        private int antall;
        private string beskrivelse;

        public Ordre(double sum, int antall, string beskrivelse)
        {
            this.antall = antall;
            this.sum = sum * antall;
            this.beskrivelse = beskrivelse;
        }

        public string getBeskrivelse()
        {
            return beskrivelse;
        }
        public int getAntall()
        {
            return antall;
        }
        public double getSum()
        {
            return sum;
        }
        public double getSumForEn()
        {
            return sum / antall;
        }
        
    }
}

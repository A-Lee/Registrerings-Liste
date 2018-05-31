using System;
using System.Collections.Generic;
using System.Text;

namespace Finally.Basics
{
    class Variables
    {
        private static int tall;
        private static double tallPresis;
        private static float  floatLol;
        private static string streng;

        public static void setValues()
        {
            tall = 1;
            tallPresis = 2.5;
            floatLol = 5.3f;
            streng = "Testing";
        }
        public void writeVariables()
        {
            Console.WriteLine($"{tall.GetType()}: {tall}");
            Console.WriteLine($"{tallPresis.GetType()}: {tallPresis}");
            Console.WriteLine($"{floatLol.GetType()}: {floatLol}");
            Console.WriteLine($"{streng.GetType()}: {streng}");
        }
    }
}

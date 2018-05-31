using System;
using System.Collections.Generic;
using System.Text;

namespace Finally.Basics
{
    class BasicMain
    {
        public static void main(String[] args)
        {
            forLoops loops = new forLoops();
            loops.printBoolLoop();
            loops.printClassLoop();
            Console.ReadKey();
            var num = Flyklasser.Highclass;
            Console.WriteLine(num);
            
        }
    }
}

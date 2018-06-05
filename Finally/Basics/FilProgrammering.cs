using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Finally.Basics
{
    class FilProgrammering
    {
        const string path = @"C:\C#Prog\Test";
        public FilProgrammering()
        {
          
        }

        public void lagFilOgMappe()
        {
            Directory.CreateDirectory(path);
            File.Create(path + @"\fil.txt");
        }
        public void sjekkBilderMappe()
        {
            var bilder = Directory.GetFiles(@"C:\Users\Ali\Pictures", "*.jpg", SearchOption.AllDirectories);
            foreach(var bilde in bilder)
            {
                Console.WriteLine(bilde);
            }
        }
    }
}

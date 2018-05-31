using System;
using System.Collections.Generic;
using System.Text;
using Finally.Mennesker;

namespace Finally.Basics
{
    class forLoops
    {
        private int[] intArray = new int[25];
        private bool[] boolArray = new bool[2];
        private Person[] klasseArray = new Person[2];

        public forLoops()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 2;
            }
            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = Convert.ToBoolean(i);
            }
           /* for(int i = 0; i < klasseArray.Length; i++)
            {
                Person p = new Person($"Solid Snake{i}", "Shadow Moses Island", 25);
                klasseArray[i] = p;
            }*/
        }

        public void printIntLoop()
        {
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Index: {i} \tValue: {intArray[i]}");
            }
        }
        public void printBoolLoop()
        {
            for (int i = 0; i < boolArray.Length; i++)
            {
                Console.WriteLine($"Index: {i} \tValue: {boolArray[i]}");
            }
        }
        public void printClassLoop()
        {
            for (int i = 0; i < klasseArray.Length; i++)
            {
                //Console.WriteLine($"Index: {i} \tValue: {klasseArray[i].toString()}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Finally.Basics
{
    class Calculator
    {
        public Calculator()
        {

        }
        public double add(params double[] numbers)
        {
            if(validNumbers(numbers))
            {
                double sum = numbers[0];

                for(int i = 1; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            Console.WriteLine("Invalid numbers passed as parameter. -1 returned");
            return -1;
           
        }
        public double subtract(params double[] numbers)
        {

            if (validNumbers(numbers))
            {
                double sum = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    sum -= numbers[i];
                }
                return sum;
            }
            Console.WriteLine("Invalid numbers passed as parameter. -1 returned");
            return -1;
        }
        public double multiply(params double[] numbers)
        {
            if (validNumbers(numbers))
            {
                double sum = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    sum *= numbers[i];
                }
                return sum;
            }
            Console.WriteLine("Invalid numbers passed as parameter. -1 returned");
            return -1;
        }
        public double divide(params double[] numbers)
        {
            if (validNumbers(numbers))
            {
                double sum = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    sum /= numbers[i];
                }
                return sum;
            }
            Console.WriteLine("Invalid numbers passed as parameter. -1 returned");
            return -1;
        }
        public bool validNumbers(double[] numbers)
        {
            if (numbers.Length < 0)
            {
                return false;
            }
            return true;
        }
    }
}

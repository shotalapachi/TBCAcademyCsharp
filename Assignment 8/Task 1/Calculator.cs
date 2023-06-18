using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal static class Calculator
    {
        public static double Add(double a, double b) { return a + b; }

        public static double Subtract(double a, double b) { return a - b; }

        public static double Multiply(double a, double b) { return a * b; }

        public static double Divide(double a, double b) { return a / b; }

        public static double Pow(double a, double b) 
        {
            double res = a;
            for (int i = 1; i < b; i++)
            {
                res *= a;
            }
            return res;
        }
        
        public static double Sqrt(double a)
        {
            double guess = a / 2;
            double lastGues;
            double testresult;

            while (true)
            {
                testresult = a - Pow(guess, 2);
                if (testresult < 0)
                    testresult *= -1;
                if (testresult < 0.00001)
                    break;
                else
                {
                    lastGues = guess;
                    guess = (lastGues + a/lastGues) / 2; 
                }
            }
            return guess;
        }
    }
}

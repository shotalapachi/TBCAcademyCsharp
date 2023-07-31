using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Integers : Interface<int>
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    } 
}

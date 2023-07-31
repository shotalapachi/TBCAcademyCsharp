using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Strings : Interface<string>
    {
        public void Add(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public void Subtract(string a, string b)
        {
            string res = "";
            for (int i = 0; i < b.Length; i++)
            {
                if (b.Contains(a[i]))
                {
                    continue;
                }
                else res += a[i];
            }
            Console.WriteLine(res);
        }

        public void Multiply(string a, string b)
        {
            Console.WriteLine(a.Length * b.Length);
        }
    }
}

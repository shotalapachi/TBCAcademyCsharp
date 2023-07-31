using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal interface Interface<T>
    {
        void Add(T a, T b);
        void Subtract(T a, T b);
        void Multiply(T a, T b);
    }
}

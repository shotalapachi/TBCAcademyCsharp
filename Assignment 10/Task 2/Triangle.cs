using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            double max = Math.Max(a, Math.Max(b, c));
            double others = a + b + c - max;
            if (max >= others)
            {
                throw new ArgumentException("The sum of two sides of a triangle must be greater than the third side");
            }
            else if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The sides of a triangle must be greater than zero");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public double Perimeter()
        {
            double perimeter = a + b + c;
            return perimeter;
        }

        public double Area()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        
        public static bool operator ==(Triangle t1, Triangle t2)
        {
            if (t1.a == t2.a && t1.b == t2.b && t1.c == t2.c)
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            if (t1.a != t2.a || t1.b != t2.b || t1.c != t2.c)
            {
                return true;
            }
            else return false;
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            if (t1.Area() > t2.Area())
            {
                return true;
            }
            else return false;
        }
        public static bool operator<(Triangle t1, Triangle t2)
        {
            if (t1.Area() < t2.Area())
            {
                return true;
            }
            else return false;
        }

        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            double area = t1.Area() + t2.Area();
            double leg = Math.Sqrt(area * 2);
            double hypotenuse = Math.Sqrt(2 * leg * leg);
            Triangle result = new Triangle(leg, leg, hypotenuse);
            return result;
        }

        public static explicit operator Triangle(double d)
        {
            Triangle result = new Triangle(d, d, d);
            return result;
        }


    }
}

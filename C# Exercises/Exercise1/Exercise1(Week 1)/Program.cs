using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Week_1_
{
    class Program
    {
        public class Complex
        {
            public double rp; //Real Part
            public double ip; //Imaginary Part

            public Complex()
            {
                rp = 0;
                ip = 0;
            }

            public Complex(double x)
            {
                rp = x;
                ip = 0;
            }

            public Complex(double x, double y)
            {
                rp = x;
                ip = y;
            }

            public static Complex Add(Complex k, Complex l)
            {
                double r = k.rp + l.rp;
                double i = k.ip + l.ip;
                Complex z = new Complex(r, i);
                return z;
            }

            public static Complex Sub(Complex x, Complex y)
            {
                double r = x.rp - y.rp;
                double i = x.ip - y.ip;
                return new Complex(r, i);
                
            }

            public Complex Add(Complex m)
            {
                double r = this.rp + m.rp;
                double i = this.ip + m.ip;
                Complex z = new Complex(r, i);
                return z;
            }

            public static Complex operator +(Complex x, Complex y)
            {
                return new Complex(x.rp + y.rp, x.ip + y.ip);
            }

            public static Complex operator -(Complex x, Complex y)
            {
                return new Complex(x.rp - y.rp, x.ip - y.ip);
            }

            public override string ToString()
            {
                return $"The result is {rp}+{ip}i";
            }
        }
        static void Main(string[] args)
        {
            Complex z1 = new Complex(2, 5);
            Complex z2 = new Complex(5, 7);
            Complex z3 = new Complex(2);

            Complex sum1 = Complex.Add(z1, z2);
            Complex sum2 = z1.Add(z2);
            Complex sum3 = z1 + z2;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Complex sum4 = Complex.Add(z1, z2).Add(z3);
            Complex sum5 = z1.Add(z2).Add(z3);
            Complex sum6 = z1 + z2 +z3;

            Console.WriteLine(sum4);
            Console.WriteLine(sum5);
            Console.WriteLine(sum6);

            Complex sub1 = z1 - z2;
            Complex sub2 = Complex.Sub(z1, z2);

            if (sub1.ip<0)
            {
                double abs = new double();
                abs = Math.Abs(sub1.ip);
                Console.WriteLine("{0}-{1}i",sub1.rp, abs);
            }
            else
            {
                Console.WriteLine(sub1);
            }

            if (sub2.ip < 0)
            {
                double abs = new double();
                abs = Math.Abs(sub2.ip);
                Console.WriteLine("{0}-{1}i", sub2.rp, abs);
            }
            else
            {
                Console.WriteLine(sub2);
            }

            Complex sub3 = z1 - z2 - z3 + sum2;

            Console.WriteLine(sub3);

            Complex sub4 = Complex.Sub(z1, z2).Add(z3);

            Console.WriteLine(sub4);

            Console.ReadKey();
        }
    }
}

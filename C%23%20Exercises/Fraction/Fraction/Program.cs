using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFraction
{
    class Program
    {
        public class Fraction:IComparable<Fraction>
        {
            public double num;
            public double denom;

            public Fraction()
            {
                num = 0;
                denom = 1;
            }

            public Fraction(double num)
            {
                this.num = num;
                denom = 1;
            }

            public Fraction(double num, double denom)
            {
                this.num = num;
                this.denom = denom;
            }

            public static Fraction operator *(Fraction f1, Fraction f2)
            {
                double multiNum = f1.num * f2.num;
                double multiDenum = f1.denom * f2.denom;
                return new Fraction(multiNum, multiDenum);
            }

            public static Fraction operator *(double f1, Fraction f2)
            {
                double multiNum = f1 * f2.num;
                double multiDenum = f2.denom;
                return new Fraction(multiNum, multiDenum);
            }

            public static Fraction operator *(Fraction f1, double f2)
            {
                double multiNum = f1.num * f2;
                double multiDenum = f1.denom;
                return new Fraction(multiNum, multiDenum);
            }

            public decimal Decimal
            {
                get { return (decimal)(num / denom); }
            }

            public static Fraction Parse(string str)
            {
                string[] split = str.Split('/');
                double a = Int32.Parse(split[0]);
                double b = Int32.Parse(split[1]);
                return new Fraction(a, b);
            }

            public override string ToString()
            {
                string result = "";
                if (denom == 0)
                {
                    result = "Zero cannot be a denominator";
                }
                else if ((num <0 && denom<0) || (num>=0 && denom>0))
                {
                    result = Math.Abs(num) + "/" + Math.Abs(denom);
                }
                else
                {
                    result = "-" + Math.Abs(num) + "/" + Math.Abs(denom);
                }
                return result;
            }

            public Fraction Cancel()
            {
                double min = Math.Min(this.num, this.denom);
                for (double i=min; i>=2; i--)
                {
                    if ((this.num%i==0) && (this.denom % i == 0))
                    {
                        this.num /= i;
                        this.denom /= i;
                    }                   
                }
                return new Fraction(this.num, this.denom);
            }

            public int CompareTo(Fraction other)
            {
                if (this.Decimal < other.Decimal)
                {
                    return -1;
                }
                else if (this.Decimal > other.Decimal)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 4); 
            Console.WriteLine(a);
            Fraction b = new Fraction(2, -3);

            Fraction c3 = a * b;
            Fraction c4 = b * a;
            Fraction c5 = 5 * c4;
            Fraction c6 = c5 * 2;
            Fraction c9 = a * b * c3 * c5 * c6;

            Console.WriteLine(a.Decimal);
            Console.WriteLine(c4.Decimal);

            Console.WriteLine(Fraction.Parse("3/5"));
            Fraction c8 = Fraction.Parse("2/5");

            List<Fraction> list = new List<Fraction>()
            {
                a, b, c3, c4, Fraction.Parse("3/5"), c8, c5, c6, c9
            };
            Console.WriteLine();

            foreach (Fraction f in list)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine();

            list.Sort();

            foreach (Fraction f in list)
            {
                Console.WriteLine(f);
            }

            Fraction c7 = new Fraction(5, 10);
            Console.Write(c9 + " ==> ");
            c9.Cancel();
            Console.WriteLine(c9);
            Console.ReadKey();
        }
    }
}

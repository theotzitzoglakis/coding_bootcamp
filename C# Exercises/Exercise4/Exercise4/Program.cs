using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        public class Students:IComparable<Students>
        {
            public string Name;
            public double Mark;

            public Students(string name, double mark)
            {
                this.Name = name;
                this.Mark = mark;
            }

            public int CompareTo(Students s)
            {
                if (this.Mark < s.Mark)
                {
                    return -1;
                }
                else if (this.Mark > s.Mark)
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
            List<Students> NameMark = new List<Students>()
            {
                new Students("John", 9.1),
                new Students("Kostas", 7.4),
                new Students("George", 4.2),
                new Students("Theo", 8.3),
                new Students("Maria", 6.1)
            };

            foreach (Students s in NameMark)
            {
                Console.WriteLine(s.Name + " got " + s.Mark);
            }
            Console.WriteLine();
            NameMark.Sort();
            Console.WriteLine("Sorted List by Mark");

            foreach (Students s in NameMark)
            {
                Console.WriteLine(s.Name + " got " + s.Mark);
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace Exercise3
{
    class Program
    {
         
        public static class Utilities
        {
           public static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            public static void SwapGeneric<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
        static void Main(string[] args)
        {
            int c = 12;
            int d = 8;
            Utilities.Swap(ref c, ref d);
            Console.WriteLine("{0}, {1}", c, d);

            string e = "Hello";
            string f = "World";
            Utilities.SwapGeneric(ref e, ref f);
            Console.WriteLine("{0}, {1}", e, f);

            Console.ReadKey();
        }
    }
}

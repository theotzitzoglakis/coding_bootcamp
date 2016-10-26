using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool i = true;
            while (i == true)
            {
                Console.WriteLine("Give me a number between 1 and 6");
                string NumberStr = Console.ReadLine();
                int Number = Convert.ToInt32(NumberStr);
                if (Number < 1 || Number > 6)
                {
                    Console.WriteLine("The number you entered is out of range");
                    continue;
                }

                Random r = new Random();
                int LuckyNumber = r.Next(1, 7);

                if (LuckyNumber == Number)
                {
                    Console.WriteLine("You win!!!!");
                    i=false;
                }
                else
                {
                    Console.WriteLine("You lose :( , the correct number was " + LuckyNumber);
                }
            }
            Console.ReadKey();
        }
    }
}

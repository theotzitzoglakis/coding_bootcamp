using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Program
    {


        static void Main(string[] args)
        {
            Device Samsung = Device.Samsung();

            Samsung.usage.NewCall(Call.CallDirection.Incoming);
            Console.WriteLine("Starting Call...");
            Console.WriteLine(Samsung);
            Random r = new Random();
            System.Threading.Thread.Sleep(r.Next(0, 30000));
            Samsung.usage.EndCall();
            Console.WriteLine("Call Ended.");

            Samsung.usage.NewCall(Call.CallDirection.Outgoing);
            Console.WriteLine("Starting Call...");
            Console.WriteLine(Samsung);
            System.Threading.Thread.Sleep(r.Next(0, 30000));
            Samsung.usage.EndCall();
            Console.WriteLine("Call Ended.");


            Console.WriteLine(Samsung.usage.ToString());

            Console.ReadKey();
        }
    }
}

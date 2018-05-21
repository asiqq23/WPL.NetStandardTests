using NetStandard1._6Package;
using NetStandard2._0Package;
using System;

namespace ClientNetCore2._0App
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1_6 = new Class1_6().Hi();
            var client2_0 = new Class2_0().Hi();

            Console.WriteLine(client1_6);
            Console.WriteLine(client2_0);

            Console.ReadKey();
        }
    }
}

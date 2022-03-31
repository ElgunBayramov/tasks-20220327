using System;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439.
            int a1;
            int a3;
            int a5;
            int a7;
            int a9;
            int eded2;
            Console.Write("ededi daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=100000000 && eded < 1000000000)
            {
                a1 = eded / 100000000;
                Console.WriteLine($"1-ci yerde dayanan reqem: {a1}");
                a3 = (eded / 1000000) % 10;
                Console.WriteLine($"3-cu yerde dayanan reqem: {a3}");
                a5 = (eded / 10000) % 10;
                Console.WriteLine($"5-ci yerde dayanan reqem: {a5}");
                a7 = (eded / 100) % 10;
                Console.WriteLine($"7-ci yerde dayanan reqem: {a7}");
                a9 = eded % 10;
                Console.WriteLine($"9-cu yerde dayanan reqem: {a9}");
                eded2 = a1 * 10000 + a3 * 1000 + a5 * 100 + a7 * 10 + a9;
                Console.WriteLine($"tek yerde dayanan reqemlerden duzelmish eded: {eded2}");
            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}

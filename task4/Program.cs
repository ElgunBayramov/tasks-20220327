using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati.
            int sum = 0;
            int a1;
            int a2;
            Console.Write("ededi daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=10000 && eded < 100000)
            {
                a1 = eded / 10000;
                Console.WriteLine($"ededin ilk reqemi: {a1}");
                a2 = eded % 10;
                Console.WriteLine($"ededin son reqemi: {a2}");
                sum = (a1 + a2) * (a1 + a2);
                Console.WriteLine($"ilk ve son reqemlerinin ceminin kvadrati: {sum}");
            }
            else
            {
                Console.WriteLine("sert duzgun odenmeyib");
            }
        }
    }
}

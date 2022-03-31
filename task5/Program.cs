using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
           
            int a1;
            int b;
            Console.Write("eded daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=100000 && eded < 1000000)
            {
                a1 = eded / 100000;
                Console.WriteLine($"{eded} ededinin birinci reqemi: {a1}");
                b = eded * 10 + a1;
                Console.WriteLine($"{eded} ededinin 1-ci reqemini ededin axirina atdiqda alinan eded: {b}");
            }
            else
            {
                Console.WriteLine("eded 6 reqemli deyil");
            }
        }
    }
}

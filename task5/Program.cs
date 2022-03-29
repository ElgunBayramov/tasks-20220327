using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
           
            int a1;
            Console.Write("eded daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=100000 && eded < 1000000)
            {
                a1 = eded / 100000;
                Console.WriteLine($"{eded}{a1}");
            }
            else
            {
                Console.WriteLine("eded 6 reqemli deyil");
            }
        }
    }
}

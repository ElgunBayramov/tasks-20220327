using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir.
            int a1;
            int a2;
            int a3;
            int a4;
            int b;
            int c;
            Console.Write("eded daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=1000 && eded < 10000)
            {
                a1 = eded % 10;
                a2 = (eded % 100 - a1) / 10;
                a3 = (eded % 1000 - a2) / 100;
                a4 = (eded % 10000 - a3) / 1000;
                b = a1 * 1000 + a2 * 100 + a3 * 10 + a4;
                Console.WriteLine($"ededin tersine cevrilmish hali: {b}");
                c = 8 * 100000 + b * 10 + 8;
                Console.WriteLine($"{b} ededinin axirina ve evveline 8 elave atdikde alinan eded: {c}");
            }
            else
            {
                Console.WriteLine("daxil edilen eded 4 reqemli deyil");
            }
        }
    }
}

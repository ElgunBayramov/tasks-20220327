using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap.
            //  int eded = 1234685;
            int last3;
            int last;
            int sum;
            Console.Write("eded daxil et: ");
            int eded=int.Parse(Console.ReadLine());
            last3 = (eded / 100) % 10;
            Console.WriteLine($"{eded} ededinin axirdan 3-cu reqemi: {last3}");
            last = eded % 10;
            Console.WriteLine($"{eded} ededinin sonuncu reqemi: {last}");
            sum = last3 + last;
            Console.WriteLine($"{eded} ededinin axirdan 3-cu reqemi ile sonuncu ededinin cemi: {sum}");
        }
    }
}

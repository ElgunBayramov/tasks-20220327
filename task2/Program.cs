using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3.
                   int sum = 0;
                   Console.Write("ededi daxil et: ");
                   int eded=int.Parse(Console.ReadLine());
            if (eded > 100000 && eded <= 1000000)
            {
                while (eded>0)
                {
                    sum = sum + (eded / 1000) % 10;
                    eded /= 10;
                }
                Console.WriteLine($"ededin ilk 3 reqeminin cemi: {sum}");
            }
            else
            {
                Console.WriteLine("eded 6 reqemli deyil");
            }
           
        }         
    }
}


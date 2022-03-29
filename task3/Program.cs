using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi.
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            Console.WriteLine("ededi daxil et: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=100000000 && eded < 1000000000)
            {
                while (eded > 0)
                {
                    sum1 = sum1 + (eded / 1000000) % 10;
                    sum2 = sum2 + (eded / 1000) % 10;
                    eded /= 10;

                }
                Console.WriteLine($"ededin ilk 3 reqeminin cemi: {sum1}");
                Console.WriteLine($"ededin ilk 6 reqeminin cemi: {sum2}");
                sum=sum2- sum1;
                Console.WriteLine($"ededin ortaya dushen 3 reqeminin cemi: {sum}");
            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}

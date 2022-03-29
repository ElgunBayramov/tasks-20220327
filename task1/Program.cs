using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmish 4 reqemli ededin reqemlerinin cemini tap.
            int sum = 0;
            Console.Write("eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a < 10000)
            {
                while (a > 0)
                {
                    sum += a % 10;
                    a /= 10;

                }
                Console.WriteLine($"ededin reqemlerinin cemi: {sum}");
            }
            else
            {
                Console.WriteLine("sert duzgun deyil");
            }
        }
    }    
}
    

using System;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            // sonra cut yerde dayanlarinda bir eded duzlet,
            // sonra onlari topla
            int a1, a2, a3, a4, a5, a6, a7, a8, a9;
            int eded2, eded3;
            int sum;
            Console.Write("ededi daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded >= 100000000 && eded < 1000000000)
            {
                a1 = eded / 100000000;
                Console.WriteLine($"1-ci yerde dayanan reqem: {a1}");
                a2 = (eded / 10000000) % 10;
                Console.WriteLine($"2-ci yerde dayanan reqem: {a2}");
                a3 = (eded / 1000000) % 10;
                Console.WriteLine($"3-cu yerde dayanan reqem: {a3}");
                a4 = (eded / 100000) % 10;
                Console.WriteLine($"4-cu yerde dayanan reqem: {a4}");
                a5 = (eded / 10000) % 10;
                Console.WriteLine($"5-ci yerde dayanan reqem: {a5}");
                a6 = (eded / 1000) % 10;
                Console.WriteLine($"6-ci yerde dayanan reqem: {a6}");
                a7 = (eded / 100) % 10;
                Console.WriteLine($"7-ci yerde dayanan reqem: {a7}");
                a8 = (eded / 10) % 10;
                Console.WriteLine($"8-ci yerde dayanan reqem: {a8}");
                a9 = eded % 10;
                Console.WriteLine($"9-cu yerde dayanan reqem: {a9}");
                eded2 = a1 * 10000 + a3 * 1000 + a5 * 100 + a7 * 10 + a9;
                Console.WriteLine($"tek yerde dayanan reqemlerden duzelmish eded: {eded2}");
                eded3 = a2 * 1000 + a4 * 100 + a6 * 10 + a8;
                Console.WriteLine($"cut yerde dayanan reqemlerden duzelmish eded: {eded3}");
                sum = eded2 + eded3;
                Console.WriteLine($"{eded2}+{eded3}={sum}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("sert duzgun odenilmeyib");
                Console.ResetColor();
            }

        }
    }
}

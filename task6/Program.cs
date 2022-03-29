using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et.
            int a1;
            int a2;
            int a3;
            Console.Write("ededi daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=10000000 && eded < 100000000)
            {
                a1 = eded / 10000000;
                Console.WriteLine($"{eded} ededinin ilk reqemi: {a1}");
                a2 = eded % 10;
                Console.WriteLine($"{eded} ededinin axrinci reqemi: {a2}");
                a3 = (eded -(a1*10000000)-a2)/10;
                Console.WriteLine($"{eded} ededinin ilk ve axrinci reqemlerini legv etdikde alinan eded:{a3}");
             }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}

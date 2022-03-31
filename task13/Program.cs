using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 5 reqemli eded var.
            // Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            // Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.
            int a1, a2, a3;
            int a, b;
            Console.Write("birinci ededi daxil et: ");
            int eded1=int.Parse(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int eded2=int.Parse(Console.ReadLine());
            Console.Write("ucuncu ededi daxil et: ");
            int eded3=int.Parse(Console.ReadLine());
            if (eded1 >= 10000 && eded1 < 100000 && eded2 >= 10000 && eded2 < 100000 && eded3 >= 10000 && eded3 < 100000)
            {
                
                a1 = (eded1 / 10000 * 10) + (eded1 % 10);
                Console.WriteLine($"{eded1} ededinin ilk ve son reqemlerinden duzelen eded: {a1}");
                a2 = (eded2 / 10000 * 10) + (eded2 % 10);
                Console.WriteLine($"{eded2} ededinin ilk ve son reqemlerinden duzelen eded: {a2}");
                a3 = (eded3 / 10000 * 10) + (eded3 % 10);
                Console.WriteLine($"{eded3} ededinin ilk ve son reqemlerinden duzelen eded: {a3}");
                a = a1 + a2 + a3;
                Console.WriteLine($"{a1}+{a2}+{a3}={a}");
                b = a + (a * 50 / 100);
                Console.WriteLine($"{a} ededi ile {a} ededinin 50 faizinin cemi: {b}");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("ededlerin her biri 5 reqemli deyil");
            }
        }
    }
}

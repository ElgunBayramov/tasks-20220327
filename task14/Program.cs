using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            // Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            // Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            // Neticenin 60 % tap.Cavabin axirina 60 artir.
            // Neticeden 18 % cix
            int a1, a2, a3, a4, b1, b2, b3,x, cem, cem1;
            int n = 60;
            double y,w,z;
            Console.Write("eded daxil et: ");
            int eded1=int.Parse(Console.ReadLine());
            Console.Write("eded daxil et: ");
            int eded2=int.Parse(Console.ReadLine());
            Console.Write("eded daxil et: ");
            int eded3=int.Parse(Console.ReadLine());
            Console.Write("eded daxil et: ");
            int eded4=int.Parse(Console.ReadLine());
            if(eded1>=100000 && eded1<1000000 && eded2>=100000 && eded2<1000000 && eded3>=100000 && eded3 < 1000000 && eded4>=1000000 && eded4<10000000)
            {
                a1 = eded1 / 1000;
                a2 = eded2 / 1000;
                a3 = eded3 / 1000;
                cem1 = a1 + a2 + a3;
                Console.WriteLine($"{a1}+{a2}+{a3}={cem1}");
                a4 = eded4 % 10000;
                Console.WriteLine($"{eded4} ededinin son 4 reqemi: {a4}");
                cem = cem1 + a4;
                Console.WriteLine($"{cem1}+{a4}={cem}");
                b1 = eded4 / 1000000;
                Console.WriteLine($"{eded4} ededinin birinci reqemi: {b1}");
                b2 = eded4 / 100000 % 10;
                Console.WriteLine($"{eded4} ededinin ikinci reqemi: {b2}");
                b3 = (eded4 / 10000 % 100) % 10;
                Console.WriteLine($"{eded4} reqeminin ucuncu reqemi: {b3}");
                x = cem - (b1 * b2 * b3);
                Console.WriteLine($"{cem}-{b1*b2*b3}={x}");
                y = x * 60 * 1.0 / 100;
                Console.WriteLine($"{x} ededinin 60 faizi: {y}");
                z = double.Parse(y.ToString() +n.ToString());
                Console.WriteLine($"{y} ededinin axirina 60 elave etdikde alinan eded: {z}{0}");
                w = z - (z * 18 * 1.0 / 100);
                Console.WriteLine($"{z} ededinin 18 faizi: {w}");
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

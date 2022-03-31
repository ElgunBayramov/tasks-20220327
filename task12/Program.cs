using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene 5 reqemli eded daxil et.
            // I ededin reqemleri ceminin usutne
            // II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir
            int cem1=0;
            int hasil1=1;
            int a, cem, eded3;
            Console.Write("birinci ededi daxil et: ");
            int eded1=int.Parse(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int eded2=int.Parse(Console.ReadLine());
            if(eded1>=10000 && eded1<100000 && eded2>=10000 && eded2 < 100000)
            {
                a = eded1 % 10;
                Console.WriteLine($"{eded1} ededinin axirinci reqemi: {a}");
                while (eded1>0)
                {
                    cem1 += eded1 % 10;
                    eded1 /= 10;
                }
                Console.WriteLine($"birinci ededin reqemlerinin cemi= {cem1}");

                while(eded2>0)
                {
                    hasil1*=eded2 % 10;
                    eded2 /= 10;
                }
                Console.WriteLine($"ikinci ededin reqemlerinin hasili= {hasil1}");
                cem = cem1 + hasil1;
                Console.WriteLine($"{cem1}+{hasil1}={cem}");
                eded3 = int.Parse(cem.ToString() + a.ToString());
                Console.WriteLine($"{cem} ededinin axirina birinci ededin en axirinci reqemini artirdiqda alinan eded: {eded3}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("daxil edilen reqemler serti odemir");
                Console.ResetColor();
            }
        }
    }
}

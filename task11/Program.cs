using System;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            // Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            // Sonra cavabin ozunden onun 18 % ni cix;
            int one_two;
            int three_four;
            int five_six;
            int seven_eight;
            int a, sum;
            double b;
            Console.Write("eded daxil edin: ");
            int eded=int.Parse(Console.ReadLine());
            if(eded>=10000000 && eded < 100000000)
            {
                one_two = eded / 10000000 * 10 + (eded / 1000000 % 10);
                Console.WriteLine($"birinci-ikinci reqemler qrupu: {one_two}");
                three_four = (eded / 100000 % 10) * 10 + (eded / 10000 % 10);
                Console.WriteLine($"ucuncu-dorduncu reqemler qrupu: {three_four}");
                five_six = (eded / 1000 % 10) * 10 + (eded / 100 % 10);
                Console.WriteLine($"besinci-altinci reqemler qrupu: {five_six}");
                seven_eight = (eded / 10 % 10) * 10 + (eded % 10);
                Console.WriteLine($"yeddinci-sekkizinci reqemler qrupu: {seven_eight}");
                sum=one_two+three_four+five_six+seven_eight;
                Console.WriteLine($"qruplarin cemi={sum}");
                a = sum * 100 + 99;
                Console.WriteLine($"{sum} ededinin axirina 99 artirdiqda alinan eded: {a}");
                b = a - (a * 18* 1.0 / 100);
                Console.WriteLine($"{a} ile {a}-in 18 faizinin ferqi= {b}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("daxil edilen eded 8 reqemli deyil");
            }
        }
    }
}

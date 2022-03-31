using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            // 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            // Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            // Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            // Sonra alinan cavabin ustune gel 6 reqemli ededi.
            // Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            // Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            // Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel
            int a, b, c, d, sum1, sum2, sum3, sum4, hasil1, hasil2;
            double faiz1, faiz2, faiz3, sum5;
            Console.Write("3 reqemli eded daxil et: ");
            int eded1 = int.Parse(Console.ReadLine());
            Console.Write("3 reqemli eded daxil et: ");
            int eded2 = int.Parse(Console.ReadLine());
            Console.Write("4 reqemli eded daxil et: ");
            int eded3 = int.Parse(Console.ReadLine());
            Console.Write("4 reqemli eded daxil et: ");
            int eded4 = int.Parse(Console.ReadLine());
            Console.Write("5 reqemli eded daxil et: ");
            int eded5 = int.Parse(Console.ReadLine());
            Console.Write("5 reqemli eded daxil et: ");
            int eded6 = int.Parse(Console.ReadLine());
            Console.Write("6 reqemli eded daxil et: ");
            int eded7 = int.Parse(Console.ReadLine());
            if(eded1>=100 && eded1<1000 && eded2 >= 100 && eded2 < 1000 && eded3 >= 1000 && eded3 < 10000 && eded4 >= 1000 && eded4 < 10000 && 
                eded5 >= 10000 && eded5 < 100000 && eded6>=10000 && eded6<100000 && eded7>=100000 && eded7 < 1000000)
            {
                sum1 = eded1 + eded2;
                Console.WriteLine($"{eded1}+{eded2}={sum1}");
                hasil1 = eded3 * eded4;
                Console.WriteLine($"{eded3}*{eded4}={hasil1}");
                sum2 = sum1 + hasil1;
                Console.WriteLine($"{sum1}+{hasil1}={sum2}");
                a=int.Parse(sum2.ToString()+7);
                Console.WriteLine($"{sum2} ededine 7 reqemini yapishdir: {a}");
                sum3 = a + eded5 + eded6;
                Console.WriteLine($"{a}+{eded5}+{eded6}={sum3}");
                hasil2 = eded1 * eded2;
                Console.WriteLine($"{eded1}*{eded2}={hasil2}");
                b = int.Parse(hasil2.ToString() + 1);
                Console.WriteLine($"{hasil2} ededine 1 reqemini yapishdir: {b}");
                c = sum3 - b;
                Console.WriteLine($"{sum3}-{b}={c}");
                sum4 = c + eded7;
                Console.WriteLine($"{c}+{eded7}={sum4}");
                d = sum4 - (sum1 + eded3 + eded4);
                Console.WriteLine($"{sum4}-{sum1}+{eded3}+{eded4}={d}");
                faiz1 = d * 18 * 1.0 / 100;
                Console.WriteLine($"{d} ededinin 18 faizi: {faiz1}");
                faiz2 = faiz1 * 3 * 1.0 / 100;
                Console.WriteLine($"{faiz1} ededinin 3 faizi: {faiz2}");
                faiz3 = faiz2 * 1 * 1.0 / 100;
                Console.WriteLine($"{faiz2} ededinin 1 faizi: {faiz3}");
                sum5 = faiz3 + eded5 + eded6;
                Console.WriteLine($"{faiz3}+{eded5}+{eded6}={sum5}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("daxil edilen ededler duzgun deyil");
                Console.ResetColor();
            }
        }
    }
}

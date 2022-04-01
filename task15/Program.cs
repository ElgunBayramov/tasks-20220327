using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            // 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            // Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            // Cavabdan 7 reqemli ededin son 5 reqemini cix.
            // Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            // Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            // Cavabin axirina 11 artir.
            // Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            // Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
            int sum1, a1, a2, a3, a4, a5, b1,b2,b3,b4,b5,c1,c2,c4,c5,sum2,sum3,sum4;
            int c3 = 11;
            double w = 88,x,y,z;
            Console.Write("3 reqemli eded daxil et: ");
            int eded1 = int.Parse(Console.ReadLine());
            Console.Write("3 reqemli eded daxil et: ");
            int eded2 = int.Parse(Console.ReadLine());
            Console.Write("6 reqemli eded daxil et: ");
            int eded3 = int.Parse(Console.ReadLine());
            Console.Write("6 reqemli eded daxil et: ");
            int eded4 = int.Parse(Console.ReadLine());
            Console.Write("7 reqemli eded daxil et: ");
            int eded5 = int.Parse(Console.ReadLine());
            if(eded1>=100 && eded1<1000 && eded2>=100 && eded2<1000 && eded3>=100000 && eded3<1000000 &&
                eded4>=100000 && eded4<1000000 && eded5>=1000000 && eded5 < 10000000)
            {
                sum1 = eded1 + eded2;
                Console.WriteLine($"{eded1}+{eded2}={sum1}");
                    a1 = sum1 % 100;
                    Console.WriteLine($"{sum1} ededinin son iki reqemi: {a1}");
                    a2 = a1 * a1;
                    Console.WriteLine($"{a1}*{a1}={a2}");
                a3 = int.Parse(eded1.ToString() + eded2.ToString());
                Console.WriteLine($"3 reqenli ededlerin bir birine yapishdirilmasindan alinan eded: {a3}");
                a4 = a2 + a3;
                Console.WriteLine($"{a2}+{a3}={a4}");
                a5 = eded5 % 100000;
                Console.WriteLine($"{eded5} ededinin son 5 reqemi: {a5}");
                b1 = a4 - a5;
                Console.WriteLine($"{a4}-{a5}={b1}");
                sum2 = eded3 + eded4;
                Console.WriteLine($"{eded3}+{eded4}={sum2}");
                    b2 = sum2 % 1000;
                    Console.WriteLine($"{sum2} ededinin son 3 reqemi: {b2}");
                sum3 = b1 + b2;
                Console.WriteLine($"{b1}+{b2}={sum3}");
                b3=eded5%10+(eded5%100/10)+(eded5%1000/100)+(eded5%10000/1000)+(eded5%100000/10000)+(eded5%1000000/100000)+(eded5/1000000);
                Console.WriteLine($"{eded5} ededinin reqemleri cemi: {b3}");
                b4 = b3 % 10;
                b5 = b3 / 10;
                c1 = int.Parse(b4.ToString() + b5.ToString());
                Console.WriteLine($"{b3} ededinin tersine cevrilmish hali: {c1}");
                sum4 = sum3 + c1;
                Console.WriteLine($"{sum3}+{c1}={sum4}");
                c2 = int.Parse(sum4.ToString() + c3.ToString());
                Console.WriteLine($"{sum4} ededinin axirina 11 yapishdirdiqda alinan eded: {c2}");
                c4 = (eded5 / 1000000) * 1000 + (eded5 / 10000 % 10) * 100 + (eded5 / 100 % 10) * 10 + eded5 % 10;
                Console.WriteLine($"{eded5} ededinde tek yerde dayanan reqemlerden duzelmish eded: {c4}");
                c5 = c2 - c4;
                Console.WriteLine($"{c2}-{c4}={c5}");
                x = c5 % 10;
                Console.WriteLine($"{c5} ededinin son reqemi: {x}");
                y = c5 / 10;
                z = double.Parse(y.ToString() + w.ToString() + x.ToString());
                Console.WriteLine($"{y} ededi ile {x} ededinin arasina 88 yapishdirdiqda alinan eded: {z}");
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

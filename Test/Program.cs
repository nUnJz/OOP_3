using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            double x1 = 1, y1 = 2; // A
            double x2 = 3, y2 = 4; // B
            double x3 = 2, y3 = 5; // C

            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine("{0:F1}", AB);
            Console.WriteLine("{0:F1}", BC);
            Console.WriteLine("{0:F1}", AC);

            Console.ReadLine();
        }
    }
}
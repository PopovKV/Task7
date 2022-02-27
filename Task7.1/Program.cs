using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
                            Area(a, b, c, out double S1);
                            Area(a1, b1, c1, out double S2);
            if (S1>S2)
            {
                Console.WriteLine("Площадь 1 треугольника больше");
            }
            else
            {
                if (S2>S1)
                {
                    Console.WriteLine("Площадь 2 треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площади трегольников равны");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Area(int a, int b, int c, out double S)
        {
            double p = (a + b + c) / 2;
            S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
    }
}

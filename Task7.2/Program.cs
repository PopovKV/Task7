using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Cube(a);
            Console.ReadKey();
        }
        static void Cube(int a)
        {
            
            double S = 6 * a * a;
            double V = a * a * a;
            Console.WriteLine(S);
            Console.WriteLine(V);
        }

    }
}

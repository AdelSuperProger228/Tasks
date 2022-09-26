using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double f = Math.Exp(x);
            double c = 0;
            if ((x - y) == 0)
                c = f * f + y * y + Math.Sin(y);
            else if ((x - y) > 0)
                c = (f - y) * (f - y) + Math.Cos(y);
            else
                c = (y - f) * (y - f) + Math.Tan(y);
            Console.WriteLine("c = {0}", c);
            Console.ReadKey();
        }
    }
}

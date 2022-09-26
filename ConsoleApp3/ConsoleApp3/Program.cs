using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y = 0;
            Console.WriteLine("Введите значение аргумента: ");
            double X = Convert.ToDouble(Console.ReadLine());
            if (-9 <= X && X < -6)
            {
                Console.WriteLine("Введите значение величины R: ");
                double R = Convert.ToDouble(Console.ReadLine());
                Y = -Math.Sqrt(Math.Pow(R, 2) - Math.Pow((X + 6), 2));
            }
            else if (-6 <= X && X <= -3) Y = X + 3;
            else if (-3 < X && X < 0)
            {
                Console.WriteLine("Введите значение величины R: ");
                double R = Convert.ToDouble(Console.ReadLine());
                Y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(X, 2));
            }
            else if (0 <= X && X <= 3) Y = -X + 3;
            else Y = 0.5 * X - 1.5;
            Console.WriteLine("Значение ординаты: " + Y);
            Console.ReadKey();
        }
    }
}

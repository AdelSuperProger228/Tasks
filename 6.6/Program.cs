using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double code1 = 095;
            double code2 = 812;
            double code3 = 0163;
            double code4 = 4242;
            double price;
            Console.WriteLine("Введите код:");
            double code = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время разговора:");
            double time = double.Parse(Console.ReadLine());
            if (code == code1)
            {
                price = time * 10;
                Console.WriteLine("Код: 095, время разговора и стоимость:" + time + " мин, " + price + " руб.");
            }
            if (code == code2)
            {
                price = time * 10;
                Console.WriteLine("Код: 812, время разговора и стоимость:" + time + " мин, " + price + " руб.");
            }
            if (code == code3)
            {
                price = time * 25.4;
                Console.WriteLine("Код: 0163, время разговора и стоимость:" + time + " мин, " + price + " руб.");
            }
            if (code == code4)
            {
                price = time * 41.5;
                Console.WriteLine("Код: 4242, время разговора и стоимость:" + time + " мин, " + price + " руб.");
            }
            Console.ReadKey();
        }
    }
}


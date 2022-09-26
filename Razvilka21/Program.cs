using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введите цифру:");
            try
            {
                var v = int.Parse(Console.ReadLine());
                int lastTwoDigits = (v % 1000) % 100;
                if (lastTwoDigits % 10 == 1 && lastTwoDigits > 20 || lastTwoDigits == 1)
                    Console.WriteLine ($"{v} рубль");
                else if ((lastTwoDigits % 10 == 2 || lastTwoDigits % 10 == 3 || lastTwoDigits % 10 == 4) && lastTwoDigits / 10 !=1)
                    Console.WriteLine($"{v} рубля");
                else
                    Console.WriteLine($"{v} рублей");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введён неверный формат, перезапустите");
            }

            Console.ReadLine();
        }
    }
}

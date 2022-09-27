using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcecreamShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chocolate = 100;
            int strawberry = 120;
            int vanilla = 80;
            int money = 0;
            Console.WriteLine("Выберите сорт мороженого: \nшоколадное-100\nклубничное-120\nванильное-80:");
            string neededIceCream = Console.ReadLine();
            switch (neededIceCream.ToLower())
            {
                case "шоколадное":
                    money = chocolate;
                    break;

                case "клубничное":
                    money = strawberry;
                    break;

                case "ванильное":
                    money = vanilla;
                    break;

                default:
                    Console.WriteLine("Такого сорта нет");
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("Выберите количество порций мороженого:");
            int amount = Int32.Parse(Console.ReadLine());
            int sum = money*amount;
            Console.WriteLine($"С вас:{sum}, внесите оплату:");
            int pay = Int32.Parse(Console.ReadLine());
            if (pay == sum)
                Console.WriteLine("Платёж прошел, наслаждайтесь мороженым");
            else if (pay > sum)
                Console.WriteLine($"Платёж прошел, ваша сдача: {pay - sum} руб. наслаждайтесь мороженым");
            else
                Console.WriteLine($"Денег недостаточно, вам нехватает {sum-pay} руб.");

            Console.ReadLine();
        }
    }
}

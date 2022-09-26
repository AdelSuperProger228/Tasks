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
            Console.WriteLine("Выберите количество порций мороженого:");
            int amount = Int32.Parse(Console.ReadLine());
            
            switch (neededIceCream.ToLower())
            {
                case "шоколадное":
                    money = chocolate * amount;
                    Console.WriteLine($"С вас: {money} рублей");
                    break;
                case "клубничное":
                    money = strawberry * amount;
                    Console.WriteLine($"С вас: {money} рублей");
                    break;
                case "ванильное":
                    money = vanilla * amount;
                    Console.WriteLine($"С вас: {money} рублей");
                    break;
            }
            int pay = Int32.Parse(Console.ReadLine());
            if (pay == money)
                Console.WriteLine("Платёж прошел, наслаждайтесь мороженым");
            else if (pay > money)
                Console.WriteLine($"Платёж прошел, ваша сдача: {pay - money} руб. наслаждайтесь мороженым");
            else
                Console.WriteLine("Денег недостаточно");

            Console.ReadLine();
        }
    }
}

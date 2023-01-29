using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine("Добро подаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет.");
            Console.Write("Сколько у Вас золота? ");
            money= Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды Вам нужно? ");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food* foodUnitPrice;
            Console.WriteLine($"У Вас в сумке {food} ед. еды и {money} монет.");
        }
    }
}

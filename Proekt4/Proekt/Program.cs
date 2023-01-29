using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rubles;
            float dollars;

            int rubToUsd = 64, usdToRub = 66;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine("Обменник валют");

            Console.Write("Введите баланс рублей: ");
            rubles = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollars= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выбирите операцию:");
            Console.WriteLine("1 - Рубли в доллары");
            Console.WriteLine("2 - Доллары в рубли");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine(); 

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Сколько хотите обменять? ");
                    exchangeCurrencyCount= Convert.ToSingle(Console.ReadLine()); 
                    if (rubles >= exchangeCurrencyCount)
                    {
                        rubles -= exchangeCurrencyCount;
                        dollars += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен доллары на рубли");
                    Console.Write("Сколько хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if ( dollars >= exchangeCurrencyCount) 
                    {
                        dollars -= exchangeCurrencyCount;
                        rubles += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во долларов");
                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланс {rubles} рублей" + $" и {dollars} долларов");
        }
    }
}

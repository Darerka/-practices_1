using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int precent;

            Console.Write("Введите кол-во денег, внесенных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыть вклад? ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент? ");
            precent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * precent;
                Console.WriteLine("В этом году у вас "+ money);
                Console.ReadLine();
            }
        }
    }
}

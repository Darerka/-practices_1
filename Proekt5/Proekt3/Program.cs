using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            string password = "1234";

            for (int i = 0; i < triesCount; i++)
            {
                Console.WriteLine("Введите пароль: "); ;
                string userIntput = Console.ReadLine();
                if (userIntput == password)
                {
                    Console.WriteLine("Верный пароль!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно");
                    Console.WriteLine("Остальость попыток " + (triesCount - i - 1));
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            num = rand.Next(0, 101);
            lower = rand.Next(num - 10, num);
            higher = rand.Next(num +1 , num+ 10);

            Console.WriteLine($"Загадано число от 1 до 100, оно больше чем {lower}, " + $"но меньше {higher}.");
            Console.WriteLine($"Что это за число? У Вас {triesCount} попыток отгадать.");

            while (triesCount-- > 0)
            {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32( Console.ReadLine() );
                if ( userInput == num)
                {
                    Console.WriteLine("Вы угадали. Это число " + num + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно. Попробуйте снова.");
                }
            }
            if (triesCount < 0)
            {
                Console.WriteLine("Вы проиграли. Не расстраивайтесь, Вам точно повезет в другой раз. Это было " + num + ".");
            }
            
        }
    }
}

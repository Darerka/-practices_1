using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = { 1, 3, 4, 5, 10, 7, 8 };
            int sum = 0;
            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if(maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(maxElement);
            */

            int[] sectors = { 6, 1, 21, 18, 10, 22 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for ( int i = 0; i < sectors.Length; i++ ) 
                {
                    Console.WriteLine($"В секторе {i+1} свободно {sectors[i]} мест.");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n \n1 - заброинровать места\n\n2 - выход из программы.\n\n");
                Console.Write("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе Вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) -1;
                        if ( sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует.");
                            break;
                        }
                        Console.Write("Сколько мест Вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if ( userPlaceAmount < 0 )
                        {
                            Console.WriteLine("Неверно кол-во мест.");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount) 
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест." + 
                                $"Остаток {sectors[userSector]}.");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование успешно!");
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                //Единственное странное, что команды станут корректо записывать после "сброса".
                //Без сброса пишется не в том месте. Без понятия почему, хотя все по практике делала
            }
        }
    }
}

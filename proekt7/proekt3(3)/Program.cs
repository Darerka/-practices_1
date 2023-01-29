using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pHealth = 100;
            int pDamage = 50;
            int enemyDamage = 50;
            int enemyHealth = 50;

            while (pHealth > 0 && enemyHealth > 0)
            {
                pHealth -= enemyDamage;
                enemyHealth -= pDamage;

                Console.WriteLine(pHealth + " игрок");
                Console.WriteLine(enemyHealth + " враг");
            }

            if(pHealth >= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья");
            }
            else if (enemyHealth <=0)
            {
                Console.WriteLine("Победа игрока");
            }
            else if (pHealth <= 0)
            {
                Console.WriteLine("Победа врага");
            }
        }
    }
}

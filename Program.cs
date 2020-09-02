using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            float bossHealth = 1000;
            float bossDamage = 100;
            float health = 500;           
            float damageRashamon = 100;
            float damageHaganzakura = 250;
            float heal = 110;
            int save = 1;
            bool rashamon = false;
            bool winOrDie = true;
            string userInput;

            while (winOrDie)
            {
                Console.WriteLine("Выберите способность для атаки : ");
                Console.WriteLine("1 - Rashamon, наносит 100 урона(позволяет использовать Haganzakura)");
                Console.WriteLine("2 - heal, восстанавливает 110 хп");
                Console.WriteLine("3 - save, защититься от урона на один ход");

                if(rashamon)
                {
                    Console.WriteLine("4 - Haganzakura, наносит 250 урона.");
                }
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        health -= bossDamage;
                        bossHealth -= damageRashamon;
                        rashamon = true;
                        break;

                    case "2":
                        health += heal;

                        if(health > 500)
                        {
                            health = 500;
                        }
                        health -= bossDamage;
                        break;

                    case "3":
                        Console.WriteLine("Вы защитились от урона босса.");
                        break;

                    case "4":
                        health -= bossDamage;
                        bossHealth += damageHaganzakura;
                        rashamon = false;
                        break;
                }
                Console.WriteLine($"У вас осталось {health} хп, у босса осталось {bossHealth} хп.\n");
                if (health <= 0)
                {
                    Console.WriteLine("Вы проиграли.");
                    winOrDie = false;
                }
                else if (bossHealth <= 0)
                {
                    Console.WriteLine("Вы победили босса.");
                    winOrDie = false;
                }                
            }
            
            
        }
    }
}

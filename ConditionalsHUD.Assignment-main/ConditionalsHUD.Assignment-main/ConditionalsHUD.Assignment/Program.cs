using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsHUD.Assignment
{
    class Program
    {
        

        static int weapon;
        static int health = 100;
        static int damage = -20;
        static int hp = +100;
        static string currentWeapon;
        static bool alive = true;
        static string currentHealth;

        static void HealthStatus()
        {
            string statusZero;
            statusZero ="Imminent Danger";

            string statusOne;
            statusOne = "Badly Hurt";

            string statusTwo;
            statusTwo = "Hurt";

            string statusThree;
            statusThree = "Healthy";

            string statusFour;
            statusFour = "Perfectly Health";

            if (health <=10)
            {
                
                currentHealth = statusZero;
                
            }

            if ( health >=11 )
            {
                
                currentHealth = statusOne;
            }

            if (health <=50)
            {
                currentHealth = statusOne;
            }

            if (health >=51)
            {
               
                currentHealth = statusTwo;
                
            }

            if (health >= 76)
            {
                currentHealth = statusThree;
            }

            if (health == 100)
            {
                currentHealth = statusFour;
            }

        }
        static void ChangeWeapon(int weapon)
        {
            string noWeapon;
            noWeapon = "No Weapon";

            string weaponZero;
            weaponZero = "Pistol";

            string weaponOne;
            weaponOne = "Shot Gun";

            string weaponTwo;
            weaponTwo = "Katana";

            string weaponThree;
            weaponThree = "Lazer";

            string weaponFour;
            weaponFour = "Sniper";

            string weaponFive;
            weaponFive = "BFG";


            if (weapon == 0)
            {
                currentWeapon = weaponZero;
            }

            if (weapon == 1)
            {
                currentWeapon = weaponOne;
            }

            if (weapon == 2)
            {
                currentWeapon = weaponTwo;
            }

            if (weapon == 3)
            {
                currentWeapon = weaponThree;
            }

            if (weapon == 4)
            {
                currentWeapon = weaponFour;
            }

            if (weapon == 5)
            {
                currentWeapon = weaponFive;
            }

            if (weapon <0)
            {
                currentWeapon = noWeapon;
            }

        }

        static void TakeDamage()
        {
            health = health + damage;
            if (health < 0)
            {
                health = 0;
                alive = false;
            }
        }

        static void Heal()
        {
            health = health + hp;
            if (health > 100)
            {
                health = 100;
                alive = true;
            }
        }
        static void ShowHUD()
        {
            Console.WriteLine("----------HUD----------");
            Console.WriteLine("       Health: " + health );
            Console.WriteLine("Health Status: " + currentHealth);
            Console.WriteLine("Current Weapon: " + currentWeapon);
            Console.WriteLine("-----------------------");
        }
        static void Main(string[] args)
        {
            ChangeWeapon(-1);
            HealthStatus();
            ShowHUD();
            Console.WriteLine("");
            Console.WriteLine("Welcome to your Doom!");
            Console.WriteLine("Start by grabbing the weapon infront of you!");
            Console.WriteLine("");
            Console.ReadKey(true);

            TakeDamage();
            TakeDamage();
            TakeDamage();
            HealthStatus();
            ChangeWeapon(0);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("You pick up the dusty old " + currentWeapon + "infront of you");
            Console.WriteLine("Better Start Shooting, Evil bat like creatures start swooping from above");
            Console.WriteLine("");
            Console.WriteLine("You constantly missing allows the bat creatures to rip you to shreads ");
            Console.WriteLine("You Lose " + (damage + damage + damage) + " Health");
            Console.WriteLine("You should really see a doctor.....");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ReadKey(true);

            Heal();
            HealthStatus();
            ChangeWeapon(5);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Wow whats that glowing shiny powerup that spawned?");
            Console.WriteLine("You pick it up...");
            Console.WriteLine("OMG!!! you gain Full Health again and transform into a ");
            Console.WriteLine( currentWeapon + "(Big Friendly Giant)");
            Console.WriteLine("Smashing into everything that crosses your path");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ReadKey(true);



            TakeDamage();
            HealthStatus();
            ChangeWeapon(-1);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You jump out of the arena, landing on a tree as your powerUp starts to run out");
            Console.WriteLine("You Made It!");
            Console.WriteLine("but you take " + damage + " damage because of the many splinters stuck in your feet");
            Console.WriteLine("");
            Console.ReadKey(true);

        }
    }
}

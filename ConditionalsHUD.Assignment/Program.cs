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
        static int hp = +10;
        static string currentWeapon;
        static bool alive = true;

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
            Console.WriteLine("------HUD------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Current Weapon: " + currentWeapon);
            Console.WriteLine("---------------");
        }
        static void Main(string[] args)
        {
           

            ShowHUD();
            ChangeWeapon(3);
            TakeDamage();
            ShowHUD();
            Heal();
            ShowHUD();
            Console.ReadKey(true);

        }
    }
}

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

        static void ChangeWeapon()
        {
            

        }

        static void TakeDamage()
        {
            health = health + damage;
        }

        static void Heal()
        {

            health = health + hp;
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
            string weaponZero;
            weaponZero = "Pistol";

            if(weapon == 0)
            {
                currentWeapon = weaponZero;
            }

            ShowHUD();
            weapon = 0;
            TakeDamage();
            ShowHUD();
            Heal();
            ShowHUD();
            Console.ReadKey(true);

        }
    }
}

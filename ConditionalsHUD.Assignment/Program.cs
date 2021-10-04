using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsHUD.Assignment
{
    class Program
    {
        string ;
        static int health = 100;
        static int damage = -20;
        static int hp = +10;

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
            Console.WriteLine("Current Weapon: ");
            Console.WriteLine("---------------");
        }
        static void Main(string[] args)
        {
            ShowHUD();
            TakeDamage();
            ShowHUD();
            Heal();
            ShowHUD();
            Console.ReadKey(true);

        }
    }
}

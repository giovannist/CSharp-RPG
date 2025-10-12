using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character(100, 100);
            HealthPotion healthPotion = new HealthPotion("Health Potion", 1);

            hero.CharStats.Health = 10;
            hero.inventory.addToInventory(healthPotion, 6);
            hero.inventory.removeFromInventory(healthPotion, 4);
            hero.inventory.showInventory();

            Utils.UpdateStats(healthPotion.consume(), hero.CharStats);
        }
    }
}   
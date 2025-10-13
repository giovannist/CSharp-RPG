using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionsManagement optionsManagement = new OptionsManagement();
            Stats stats = new Stats(0, 10);
            Character mainCharacter = new Character(stats, new LocationCityCenter());

            HealthPotion healthPotion = new HealthPotion("Health Potion", 1);

            LocationCityCenter cityCenter = new LocationCityCenter();
            LocationFarm farm = new LocationFarm();
            LocationTavern tavern = new LocationTavern();

            cityCenter.ShowDialogueOptions();
            farm.ShowDialogueOptions();

            mainCharacter.CharStats.Health = 10;
            mainCharacter.inventory.addToInventory(healthPotion, 6);
            mainCharacter.inventory.removeFromInventory(healthPotion, 4);
            mainCharacter.inventory.showInventory();

            optionsManagement.showCurrentLocationOptions(mainCharacter);
            optionsManagement.promptPlayer(mainCharacter);
        }
    }
}   
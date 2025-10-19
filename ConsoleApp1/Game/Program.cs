using RPG.Core;
using RPG.Items;
using RPG.UI;
using RPG.World;

namespace RPG
{
    public class Game
    {
        Character playerCharacter;
        public Game()
        {
            Stats playerStats = new Stats(100, 100);
            Location startingLocation = new LocationCityCenter();
            playerCharacter = new Character(playerStats, startingLocation);
        }

        public void Run()
        {
            while (true)
            {
                Location current = playerCharacter.location;

                if (current is Shop shop)
                {
                    shop.EnterShop(playerCharacter);
                }

                string title = $"You are in {current.Name}";

                var options = current.Options;
                if (options == null || options.Count == 0)
                {
                    Console.WriteLine("No locations to move to...");
                    break;
                }

                // generic menu
                Location selectedLocation = ConsoleMenu.Show(title, options);

                // update player state
                playerCharacter.changeLocation(selectedLocation);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }
}
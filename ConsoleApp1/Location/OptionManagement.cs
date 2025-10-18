using System.Net;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    public class OptionsManagement
    {
        public void showCurrentLocationOptions(Character character)
        {
            Location charLocation = character.getCurrentLocation();
            Location[] charOptions = charLocation.Options;

            int num = 1;

            Console.WriteLine($"Current Location:{charLocation.Name}");
            foreach (var location in charOptions)
            {
                Console.WriteLine($"{num}. {location.Name}");
                num++;
            }
        }



        public List<Location> GetLocationOptions(Character character)
        {
            return character.getCurrentLocation().Options.ToList();
        }

        public void handlePlayerInput(string response, Character character)
        {
            int ignoreMe;
            bool isNum = int.TryParse(response, out ignoreMe);
            Location[] characterLocations = character.getCurrentLocation().Options;

            if (!isNum)
            {
                InvalidInputResponse(character);
                return;
            }

            int responseNum = Convert.ToInt32(response);

            if (responseNum < 1 || responseNum > characterLocations.Length)
            {
                InvalidInputResponse(character);
                return;
            }

            Location locationInput = characterLocations[responseNum - 1];

            character.changeLocation(locationInput);
            showCurrentLocationOptions(character);
            promptPlayer(character);
            return;
        }

        public void promptPlayer(Character character)
        {
            Console.Write($"Input : ");
            string? response = Console.ReadLine();
            handlePlayerInput(response, character);
        }

        public void InvalidInputResponse(Character character)
        {
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Invalid Input, try again");
            showCurrentLocationOptions(character);
            promptPlayer(character);
            return;
        }

        public static void LocationNavigationOptions(Character character)
        {
            OptionsManagement optionsManagement = new();

            List<Location> options = optionsManagement.GetLocationOptions(character);

            if (options == null || options.Count == 0)
            {
                Console.WriteLine("No options available.");
                return;
            }

            int selected = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.WriteLine($"You're in {character.getCurrentLocation().Name}");


                for (int i = 0; i < options.Count; i++)
                {
                    if (i == selected)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($">  {options[i].Name}  ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($">  {options[i].Name}  ");
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0) selected = options.Count - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= options.Count) selected = 0;
                }

            } while (key != ConsoleKey.Enter);

            Console.Clear();

            Console.WriteLine($"You selected: {options[selected].Name}");

            character.changeLocation(options[selected]);

            LocationNavigationOptions(character);
        }
    }
}
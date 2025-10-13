using System.Net;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class OptionsManagement
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
        
        public void handlePlayerInput(string response, Character character)
        {
            int ignoreMe;
            bool isNum = int.TryParse(response, out ignoreMe);
            Location[] characterLocations = character.getCurrentLocation().Options;

            if (!isNum)
            {
                invalidInputResponse(character);
                return;
            }

            int responseNum = Convert.ToInt32(response);
            
            if (responseNum < 1 || responseNum > characterLocations.Length)
            {
                invalidInputResponse(character);
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
        public void invalidInputResponse(Character character)
        {
                Console.WriteLine("----------------------\n");
                Console.WriteLine("Invalid Input, try again");
                showCurrentLocationOptions(character);
                promptPlayer(character);
                return;
        }
    }
}
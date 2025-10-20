using RPG.Core;
using RPG.Enemies;
using RPG.World;

namespace RPG.UI
{
    // class for all menu interface logic
    public static class ConsoleMenu
    {
        public static T Show<T>(string title, IEnumerable<T> options)
        {
            // We need a list to use an indexer
            var optionsList = options.ToList();
            if (optionsList.Count == 0)
            {
                // Handle empty menus gracefully
                throw new ArgumentException("Menu options cannot be empty.");
            }

            int selected = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(title);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("+-------------------------------------+");

                for (int i = 0; i < optionsList.Count; i++)
                {
                    string displayText = GetOptionDisplay(optionsList[i]);

                    int spacing = 35 - displayText.Length;
                    if (spacing < 0) spacing = 0;

                    string locationDisplay;

                    if (i == selected)
                    {
                        locationDisplay = $"{Colors.GREY}|{Colors.NORMAL} {Colors.BLUE}>{Colors.NORMAL} {Colors.BLUE}{displayText}{Colors.NORMAL}";
                        spacing -= 2;
                    }
                    else
                    {
                        locationDisplay = $"{Colors.GREY}| {Colors.NORMAL}{displayText}{Colors.NORMAL}";
                    }

                    locationDisplay += new string(' ', spacing);
                    locationDisplay += $"{Colors.GREY}|{Colors.NORMAL}";
                    Console.WriteLine(locationDisplay);
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("+-------------------------------------+");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0) selected = optionsList.Count - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= optionsList.Count) selected = 0;
                }

            } while (key != ConsoleKey.Enter);

            Console.Clear();

            return optionsList[selected];
        }

        private static string GetOptionDisplay<T>(T option)
        {
            var prop = typeof(T).GetProperty("DisplayName");
            if (prop != null)
            {
                return prop.GetValue(option)?.ToString() ?? "null";
            }

            // for locations
            var nameProp = typeof(T).GetProperty("Name");
            if (nameProp != null)
            {
                return nameProp.GetValue(option)?.ToString() ?? "null";
            }

            return option?.ToString() ?? "null";
        }

        public static T BattleInterface<T>(Character character, Enemy enemy, IEnumerable<T> options, string log)
        {
            var optionsList = options.ToList();
            int selected = 0;
            ConsoleKey key;

            string playerLV = $"Player Lv.{character.stats.Level}";
            string playerHP = $"HP:{character.stats.Health}/{character.stats.MaxHealth}";
            int spacingLV = 32 - playerLV.Length;
            int spacingHP = 32 - playerHP.Length;

            string pUI1 = $"+--------------------------------+";

            string pUI2 = $"|{playerLV}";
            pUI2 += new string(' ', spacingLV);
            pUI2 += "|";

            string pUI3 = $"|{playerHP}";
            pUI3 += new string(' ', spacingHP);
            pUI3 += "|";

            string pUI4 = $"|                                |";
            string pUI5 = $"|                                |";
            string pUI6 = $"|                                |";
            string pUI7 = $"+--------------------------------+";

            string enemyLV = $"{enemy.name} Lv. {enemy.level}";
            string enemyHP = $"HP:{enemy.health}/{enemy.maxHealth}";

            string eUI1 = $"       +--------------------------------+";

            string eUI2 = $"       |{enemy.name} Lv.{enemy.level}";
            eUI2 += new string(' ', spacingLV + 2);
            eUI2 += "|";

            string eUI3 = $"       |HP:{enemy.health}/{enemy.maxHealth}";
            eUI3 += new string(' ', spacingHP + 2);

            eUI3 += "|";

            string eUI4 = $"       |                                |";
            string eUI5 = $"       |                                |";
            string eUI6 = $"       |                                |";
            string eUI7 = $"       +--------------------------------+";
            string enemyUI = $"{pUI1}\n{pUI2}\n{pUI3}\n{pUI4}\n{pUI5}\n{pUI6}\n{pUI7}\n";

            pUI1 += eUI1;
            pUI2 += eUI2;
            pUI3 += eUI3;
            pUI4 += eUI4;
            pUI5 += eUI5;
            pUI6 += eUI6;
            pUI7 += eUI7;

            string PlayerUI = $"{pUI1}\n{pUI2}\n{pUI3}\n{pUI4}\n{pUI5}\n{pUI6}\n{pUI7}";

            do
            {
                Console.Clear();

                Console.Write($"{PlayerUI}\n\n");

                Console.WriteLine($"+--------------- OPTIONS --------------+             -{log}");

                for (int i = 0; i < optionsList.Count; i++)
                {
                    string displayText = GetOptionDisplay(optionsList[i]);

                    int spacing = 37 - displayText.Length;
                    if (spacing < 0) spacing = 0;

                    string locationDisplay;

                    if (i == selected)
                    {
                        locationDisplay = $"{Colors.GREY}|{Colors.NORMAL} {Colors.BLUE}>{Colors.NORMAL} {Colors.BLUE}{displayText}{Colors.NORMAL}";
                        spacing -= 2;
                    }
                    else
                    {
                        locationDisplay = $"{Colors.GREY}| {Colors.NORMAL}{displayText}{Colors.NORMAL}";
                    }

                    locationDisplay += new string(' ', spacing);
                    locationDisplay += $"{Colors.GREY}|{Colors.NORMAL}";
                    Console.WriteLine(locationDisplay);
                }

                Console.WriteLine("+--------------------------------------+");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0) selected = optionsList.Count - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= optionsList.Count) selected = 0;
                }

            } while (key != ConsoleKey.Enter);


            Console.Clear();

            return optionsList[selected];
        }
    }
}
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
    }
}
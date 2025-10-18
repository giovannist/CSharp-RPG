using System;
using System.Diagnostics.Contracts;

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

            mainCharacter.CharStats.Health = 10;
            mainCharacter.Inventory.addToInventory(healthPotion, 6);
            mainCharacter.Inventory.removeFromInventory(healthPotion, 4);
            // mainCharacter.Inventory.showInventory();

            OptionsManagement.LocationNavigationOptions(mainCharacter);

            // optionsManagement.showCurrentLocationOptions(mainCharacter);
            // optionsManagement.promptPlayer(mainCharacter);

            // navigationOptions(optionsManagement, mainCharacter);

            // Category VisualNovels2023 = new Category("Visual Novels 2023", 1517, 39, 360, 524, 188, 275, 131);
            // Category VisualNovels2024 = new Category("Visual Novels  2024", 1965, 53, 533, 666, 225, 355, 133);
            // Category VisualNovels2025 = new Category("Visual Novels  2025", 1678, 145, 492, 534, 170, 247, 90);

            // Category Platformers2D2023 = new Category("2D Platformers 2023", 1542, 140, 589, 500, 115, 132, 66);
            // Category Platformers2D2024 = new Category("2D Platformers 2024", 1978, 228, 809, 585, 135, 145, 76);
            // Category Platformers2D2025 = new Category("2D Platformers 2025", 1470, 227, 616, 406, 82, 100, 39);

            // Category Roguelikes2023 = new Category("Roguelikes 2023", 1077, 40, 341, 331, 829, 138, 138);
            // Category Roguelikes2024 = new Category("Roguelikes 2024", 1606, 88, 501, 496, 148, 217, 156);
            // Category Roguelikes2025 = new Category("Roguelikes 2025", 1418, 90, 497, 387, 121, 204, 119);

            // Category Cozy2023 = new Category("Cozy 2023", 144, 1, 21, 35, 25, 36, 26);
            // Category Cozy2024 = new Category("Cozy 2024", 377, 8, 55, 99, 64, 80, 71);
            // Category Cozy2025 = new Category("Cozy 2025", 413, 13, 72, 154, 44, 76, 54);

            // Category Management2023 = new Category("Management 2023", 738, 20, 162, 204, 75, 135, 142);
            // Category Management2024 = new Category("Management 2024", 1040, 36, 257, 281, 110, 188, 168);
            // Category Management2025 = new Category("Management 2025", 1147, 68, 320, 290, 114, 220, 135);

            // Category HackNSlash2023 = new Category("Hack N Slash 2023", 609, 23, 169, 215, 55, 75, 72);
            // Category HackNSlash2024 = new Category("Hack N Slash 2024", 795, 48, 253, 245, 52, 103, 94);
            // Category HackNSlash2025 = new Category("Hack N Slash 2025", 625, 58, 197, 164, 56, 81, 69);

            // Category Simulation2023 = new Category("Simulation 2023", 3033, 130, 824, 980, 300, 444, 355);
            // Category Simulation2024 = new Category("Simulation 2024", 4078, 219, 1187, 1239, 413, 597, 423);
            // Category Simulation2025 = new Category("Simulation 2025", 3740, 328, 1233, 997, 335, 521, 326);

            // Category BaseBuilding2023 = new Category("Base Building 2023", 523, 17, 121, 149, 45, 102, 89);
            // Category BaseBuilding2024 = new Category("Base Building 2024", 692, 44, 180, 153, 57, 119, 139);
            // Category BaseBuilding2025 = new Category("Base Building 2025", 579, 31, 151, 142, 54, 103, 98);

            // Category Economy2023 = new Category("Economy 2023", 320, 2, 73, 85, 34, 60, 66);
            // Category Economy2024 = new Category("Economy 2024", 507, 13, 110, 138, 57, 109, 80);
            // Category Economy2025 = new Category("Economy 2025", 595, 21, 160, 141, 74, 122, 77);

            // Category Sandbox2023 = new Category("Sandbox 2023", 885, 21, 219, 269, 75, 126, 175);
            // Category Sandbox2024 = new Category("Sandbox 2024", 1077, 46, 269,278, 102, 183, 199);
            // Category Sandbox2025 = new Category("Sandbox 2025", 939, 54, 271, 213, 102, 167, 132);

            // Category[] categories = [VisualNovels2023,VisualNovels2024,VisualNovels2025, Platformers2D2023, Platformers2D2024, Platformers2D2025, Roguelikes2023, Roguelikes2024, Roguelikes2025, Cozy2023, Cozy2024, Cozy2025, Management2023, Management2024, Management2025, HackNSlash2023, HackNSlash2024, HackNSlash2025, Simulation2023, Simulation2024, Simulation2025, BaseBuilding2023, BaseBuilding2024, BaseBuilding2025, Economy2023,Economy2024, Economy2025, Sandbox2023, Sandbox2024,];

            // foreach (Category category in categories)
            // {
            //     Console.WriteLine($"\n{category.name}:");

            //     float calc0 = category.noReviews / category.totalGames * 100;
            //     Console.WriteLine($"0: {calc0:F2}%");

            //     float calc1 = category.oneToNine / category.totalGames * 100;
            //     Console.WriteLine($"1-9: {calc1:F2}%");

            //     float calc2 = category.tenToFourtyNine/ category.totalGames * 100;
            //     Console.WriteLine($"10-49: {calc2:F2}%");

            //     float calc3 = category.fiftyToNinetyNine / category.totalGames * 100;
            //     Console.WriteLine($"50-99: {calc3:F2}%");

            //     float calc4 = category.hundredToFourHundredNinetyNine / category.totalGames * 100;
            //     Console.WriteLine($"100-499: {calc4:F2}%");

            //     float calc6 = (category.fiftyToNinetyNine + category.hundredToFourHundredNinetyNine + category.fiveHundredPlus) / category.totalGames * 100;
            //     Console.WriteLine($">49: {calc6:F2}%");

            //     float calc7 = (category.hundredToFourHundredNinetyNine + category.fiveHundredPlus) / category.totalGames * 100;
            //     Console.WriteLine($">100: {calc7:F2}% ");

            //     float calc5 = category.fiveHundredPlus  / category.totalGames * 100;
            //     Console.WriteLine($">500: {calc5:F2}%");

            //     Console.WriteLine($"Total: {category.totalGames}");
            // }
        }


                    // class Category
            // {
            //     public string name;
            //     public float totalGames;
            //     public float noReviews;
            //     public float oneToNine;
            //     public float tenToFourtyNine;
            //     public float fiftyToNinetyNine;
            //     public float hundredToFourHundredNinetyNine;
            //     public float fiveHundredPlus;
            //     public Category(string name, float totalGames, float noReviews,  float oneToNine, float tenToFourtyNine, float fiftyToNinetyNine,  float hundredToFourHundredNinetyNine, float fiveHundredPlus)
            //     {
            //         this.totalGames = totalGames; 
            //         this.noReviews = noReviews;
            //         this.oneToNine = oneToNine;
            //         this.tenToFourtyNine = tenToFourtyNine;
            //         this.fiftyToNinetyNine = fiftyToNinetyNine;
            //         this.hundredToFourHundredNinetyNine = hundredToFourHundredNinetyNine;
            //         this.fiveHundredPlus = fiveHundredPlus;
            //         this.name = name;
            //     }
            // }
    }
}       
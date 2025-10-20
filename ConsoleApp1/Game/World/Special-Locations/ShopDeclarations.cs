using RPG.Items;

namespace RPG.World
{
    class ShopCityCenter : Shop
    {

        private static readonly IReadOnlyList<Location> options = new List<Location>
        {
            new LocationCityCenter(),
        }.AsReadOnly();
        public override IReadOnlyList<Location> Options => options;

        private List<Item> cityCenterStock = new()
        {
            new HealthPotion("Small Potion", 5, 5, 15),
            new HealthPotion("Big Potion", 2, 10, 25),
        };
        public override List<Item> stock => cityCenterStock;
    }
}

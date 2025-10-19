using RPG.World;

namespace RPG.Core
{
    public class Character
    {
        private int gold = 0;
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        public Stats stats { get; set; }
        public Location location { get; private set; }

        public Inventory inventory { get; private set; } = new Inventory();

        public Character(Stats stats, Location startingLocation, int startingGold = 5)
        {
            this.stats = stats;
            location = startingLocation;
            gold = startingGold;
        }

        public void changeLocation(Location location)
        {
            this.location = location;
        }
    }

}
namespace HelloWorld
{

    public class Character
    {
        private Stats charStats;
        public Stats CharStats
        {
            get { return charStats; }
            set { charStats = value; }
        }
        Location currentLocation;
        private int gold = 0;
        public int Gold
        {
            get { return Gold; }
            set { Gold = value; }
        }
        
        public Inventory Inventory { get; private set; } = new Inventory();


        public Character(Stats stats, Location currentLocation)
        {
            charStats = stats;
            this.currentLocation = currentLocation;
        }
        public Location getCurrentLocation()
        {
            return currentLocation;
        }
        public void changeLocation(Location location)
        {
            currentLocation = location;
        }
    }
}

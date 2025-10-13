namespace HelloWorld
{

    class Character
    {
        Stats charStats;
        Location currentLocation;
        public Inventory inventory { get; private set; } = new Inventory();
        public Stats CharStats
        {
            get { return charStats; }
            set { charStats = value; }
        }

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

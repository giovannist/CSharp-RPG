namespace HelloWorld
{

    class Character
    {
        Stats charStats;
        public Inventory inventory { get; private set; } = new Inventory();
        public Stats CharStats
        {
            get { return charStats; }
            set { charStats = value; }
        }

        public Character(int maxHealth, int health)
        {
            charStats = new Stats(maxHealth, health);
        }
    }
}


namespace HelloWorld
{
    public class Stats
    {
        private int maxHealth;
        private int health;
        private int minBaseDamage;
        private int maxBaseDamage;
        private int equippedWeapon;
        private int equippedArmorChest;
        private int equippedArmorLegs;
        private int equippedArmorHead;
        private int equippedArmorFeet;


        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Stats(int maxHealth, int health)
        {
            this.maxHealth = maxHealth;
            this.health = health;
        }
    }
}

namespace RPG.Enemies
{
    public class Enemy
    {
        public string name;
        public int health;
        public int maxHealth;
        public int baseDamage;
        public int level;

        public Enemy(string name, int maxHealth, int baseDamage, int level)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            health = maxHealth;
            this.baseDamage = baseDamage;
            this.level = level;
        }
    }
}
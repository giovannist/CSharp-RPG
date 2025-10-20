namespace RPG.Core
{
    public class Stats
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;
        public int MaxExperience { get; set; } = 100;
        public int MinDamage { get; set; } = 4;
        public int MaxDamage { get; set; } = 8;

        public Stats(int maxHealth, int health)
        {
            MaxHealth = maxHealth;
            Health = health;
        }
        
        public void Add(Stats statsToAdd)
        {
            this.MaxHealth += statsToAdd.MaxHealth;
            this.Health += statsToAdd.Health;
            if (this.Health > this.MaxHealth)
            {
                 this.Health = this.MaxHealth;
            }      
        }
    }
}
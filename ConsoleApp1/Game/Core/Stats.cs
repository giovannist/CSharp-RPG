namespace RPG.Core
{
    public class Stats
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }

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
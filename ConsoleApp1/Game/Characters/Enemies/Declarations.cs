namespace RPG.Enemies
{
    public class Wolf : Enemy
    {
        public Wolf(string name, int maxHealth, int baseDamage, int level) : base(name, maxHealth, baseDamage, level) { }
    }
    
    public class EnemyDeclarations
    {
        private Wolf wolf = new Wolf("Wolf", 20, 3, 3);

        public Wolf Wolf 
        {
            get { return wolf; }
        }
    }
}
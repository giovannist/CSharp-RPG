namespace HelloWorld
{
    static class Utils
    {
        public static void UpdateStats(Stats statsToAdd, Stats actualStats)
        {
            actualStats.MaxHealth += statsToAdd.MaxHealth;
            actualStats.Health += statsToAdd.Health;
        }
    }
}
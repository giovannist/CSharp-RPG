
namespace RPG.World
{
    public class BattleForest : Battle
    {
        public override string Name => "Battle Forest";

        private readonly IReadOnlyList<Location> options = new List<Location>()
        {
            new LocationForest(),
        };

        public override IReadOnlyList<Location> Options => options;

    }
}
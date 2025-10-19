namespace RPG.World // For Locaton Logic
{
    public abstract class Location
    {
        public abstract string Name { get; }

        public abstract IReadOnlyList<Location> Options { get; }
    }
}
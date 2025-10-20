using RPG.World;

public class LocationCityCenter : Location
{
    public override string Name => "City Center";
    private static readonly IReadOnlyList<Location> options = new List<Location>
    {
        new LocationFarm(),
        new LocationTavern(),
        new ShopCityCenter()
    }.AsReadOnly();

    public override IReadOnlyList<Location> Options => options;
}

public class LocationFarm : Location
{
    public override string Name => "Farm";
    private static readonly IReadOnlyList<Location> options = new List<Location>
    {
        new LocationCityCenter(),
        new LocationForest(),
    }.AsReadOnly();

    public override IReadOnlyList<Location> Options => options;
}

public class LocationTavern : Location
{
    public override string Name => "Tavern";
    private static readonly IReadOnlyList<Location> options = new List<Location>
    {
        new LocationCityCenter(),
    }.AsReadOnly();

    public override IReadOnlyList<Location> Options => options;
}

public class LocationForest : Location
{
    public override string Name => "Forest";
    private static readonly IReadOnlyList<Location> options = new List<Location>
    {
        new LocationFarm(),
        new BattleForest(),
    }.AsReadOnly();

    public override IReadOnlyList<Location> Options => options;
}
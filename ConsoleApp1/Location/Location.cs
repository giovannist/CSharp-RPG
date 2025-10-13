namespace HelloWorld
{
abstract class Location
{
    public abstract string Name { get; }
    public abstract Location[] Options { get; }

    public void ShowDialogueOptions()
    {
        int num = 1;
        foreach (var location in Options)
        {
            Console.WriteLine($"{num}. {location.Name}");
            num++;
        }
    }
}

    class LocationCityCenter : Location
    {
        public override string Name => "City Center";
        public override Location[] Options => [new LocationTavern(), new LocationFarm()];
    }
    class LocationTavern : Location
    {
        public override string Name => "Tavern";
        public override Location[] Options => [new LocationCityCenter()];
    }

    class LocationFarm : Location
    {
        public override string Name => "Farm";
        public override Location[] Options => [new LocationCityCenter()];
    }
}
namespace HelloWorld
{
    public class LocationCityCenter : Location
    {
        public override string Name => "City Center";
        public override Location[] Options => [new LocationTavern(), new LocationFarm()];
    }
    public class LocationTavern : Location
    {
        public override string Name => "Tavern";
        public override Location[] Options => [new LocationCityCenter()];
    }

    public class LocationFarm : Location
    {
        public override string Name => "Farm";
        public override Location[] Options => [new LocationCityCenter()];
    }
}

namespace HelloWorld {
    public abstract class Consumable : Item
    {

    public override bool isStackable { get; } = true;
    public Consumable(string itemName, int count) : base(itemName)
    {
        Amount = count;
    }

    public abstract Stats consume();

}

    class HealthPotion : Consumable
    {
        public HealthPotion(string itemName, int count) : base(itemName, count)
        {
            itemName = "Health Potion";
        }
        public override Stats consume()
        {
            Stats stats = new Stats(0, 10);
            return stats;
        }
    }
}

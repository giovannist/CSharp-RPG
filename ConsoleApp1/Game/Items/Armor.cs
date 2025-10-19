using RPG.Core;

namespace RPG.Items
{
    abstract class Armor : Item
    {
        public override bool isStackable { get; } = false;
        public virtual Stats Stats { get; }
        public Armor(string itemName, int price, Stats stats) : base(itemName, price)
        {
            Stats = stats;
        }
    }
}
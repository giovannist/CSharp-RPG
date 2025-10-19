using RPG.Core;

namespace RPG.Items
{
    public abstract class Consumable : Item
    {
        public override bool isStackable { get; } = true;
        public Consumable(string itemName, int count, int price) : base(itemName, price)
        {
            Amount = count;
        }

        public abstract Stats Consume();

    }

    public class HealthPotion : Consumable
    {
        private readonly int healAmount;
        public override int id => 001;
        public HealthPotion(string itemName, int count, int price, int healAmount) : base(itemName, count, price)
        {
            this.healAmount = healAmount;
        }
        public override Stats Consume()
        {
            return new Stats(0, healAmount);
        }
    }


}

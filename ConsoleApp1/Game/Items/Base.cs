namespace RPG.Items
{   
    public abstract class Item
    {
        private string name;
        private int amount = 0;
        public int price;
        public virtual int id { get; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public virtual bool isStackable { get; } = false;

        public Item(string itemName, int price)
        {
            name = itemName;
            this.price = price;
        }
        public void addAmount(int num)
        {
            Amount += num;
        }
    }
}   
namespace HelloWorld
{
    class Armor:Item
    {
        public virtual Stats stats { get; }
        public Armor(string itemName): base(itemName){}
    }
}
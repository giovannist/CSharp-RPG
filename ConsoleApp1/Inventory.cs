namespace HelloWorld
{
    public class Inventory
    {
        // Item[] items = new Item[];
        private List<Item> _items = new List<Item>
        {
        };
        public void showInventory()
        {
            
            foreach (Item item in _items)
            {
                Console.WriteLine($"{item.Name} x{item.Amount}");
            }

        }

        public void addToInventory(Item obj, int amountToAdd)
        {
            if (amountToAdd <= 0) return; // throw error

            if (obj.isStackable)
            {
                Item? existing = _items.Find(i => i.GetType() == obj.GetType());
                if (existing != null)
                {
                    existing.Amount += amountToAdd;
                    return;
                }
            }
            obj.Amount = amountToAdd;
            _items.Add(obj);
        }
        public void removeFromInventory(Item obj, int amountToRemove)
        {

            if (amountToRemove <= 0) return;
            
            for (int i = 0; i < _items.Count; i++)
            {
                Item item = _items[i];
                bool isSameType = item.GetType() == obj.GetType();

                if (!isSameType)
                {
                    continue;
                }

                bool areBothStackable = obj.isStackable && item.isStackable;
                bool isHigher = item.Amount > amountToRemove;

                if (areBothStackable && isHigher)
                {
                    item.addAmount(-amountToRemove);
                    return;
                }
                _items.RemoveAt(i);
            }
        }
    }
}
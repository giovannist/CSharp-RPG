namespace HelloWorld
{
    class Inventory
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
            if (amountToAdd <= 0) return;

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
                if (_items[i].GetType() == obj.GetType() && obj.isStackable && _items[i].isStackable) // if item is stackable...
                {
                    if (_items[i].Amount > amountToRemove)
                    {
                        _items[i].addAmount(-amountToRemove);
                        return;
                    }
                    _items.RemoveAt(i); 
                    return;
                }
                else if (_items[i].GetType() == obj.GetType() && obj.isStackable == false && _items[i].isStackable == false)
                {
                    _items.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
using RPG.Items;

namespace RPG.Core
{
    public class Inventory
    {
        private readonly List<Item> items = new();
        public IReadOnlyList<Item> Items => items.AsReadOnly(); // c# read-only list

        public void ShowInventory()
        {
            // shouldn't direct write to the console, but to be used by a specialized UI class
            Console.WriteLine("+---- INVENTORY ----+");

            if (items.Count < 1)
            {
                Console.WriteLine(" Empty ");
                return;
            }

            foreach (Item item in items)
            {
                Console.WriteLine($"- {item.Name} x{item.Amount}");
            }

            Console.WriteLine("+-------------------+");
        }

        public void Add(Item itemToAdd, int amount)
        {
            if (amount <= 0) return;

            if (itemToAdd.isStackable)
            {
                Item? existing = items.Find(i => i.GetType() == itemToAdd.GetType()); // this creates a reference, not a copy
                if (existing != null)
                {
                    existing.addAmount(amount); // so this makes sense
                    return;
                }
            }
            itemToAdd.Amount = amount;
            items.Add(itemToAdd);
        }
        
        public void Remove(Item itemToRemove, int amount)
        {
            Item? itemInInventory = items.Find(i => i.GetType() == itemToRemove.GetType());

            if (itemInInventory == null) // if couldnt find  item
            {
                Console.WriteLine($"Couldn't findd item {itemToRemove}");
                return;
            }

            if (itemInInventory.isStackable) 
            {
                if (itemInInventory.Amount > amount) // checking if the item should be removed entirely
                {
                    itemInInventory.addAmount(-amount);
                }
                else
                {
                    items.Remove(itemInInventory);
                }
            }
            else // if it isnt stackable
            {
            items.Remove(itemInInventory);   
            }
        }
    }
}
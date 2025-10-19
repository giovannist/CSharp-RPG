namespace HelloWorld
{
    abstract public class Location
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

    public class Shop
    {
        int size;
        Item[] items;

        Shop(Item[] items)
        {
            this.items = items;
        }

        public void SellItemToChararacter(Item item, Character character)
        {
            if (items.Contains(item))
            {
                if (item.price > character.Gold)
                {
                }
                else
                {
                    
                }
            }
        }
    }

}
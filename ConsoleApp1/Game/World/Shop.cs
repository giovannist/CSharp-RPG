using RPG.Items;
using RPG.Core;
using RPG.UI;

namespace RPG.World
{
    abstract public class Shop: Location
    {
        public override string Name => "Shop";


        public virtual List<Item> stock { get; }


        public void SellItemToChararacter(Item item, Character character)
        {
            if (!stock.Contains(item))
            {
                Console.WriteLine("ERROR: Couldn't find Item");
                return;
            }

            if (item.price > character.Gold)
            {
                Console.WriteLine($"You're missing {item.price - character.Gold}g!");
                Console.ReadKey();
            }
            else
            {
                character.Gold -= item.price;
                // Item purchasedItem = CreateItemInstance(item); will do without this for now, writing it cause it might bite me later
                // character.Inventory.Add(purchasedItem, 1);
                character.inventory.Add(item, 1);
                Console.ReadKey();
            }
        }

        public void PurchaseConfirmation(Item item, Character character)
        {
            bool confirmingBuy = true;

            List<IMenuOption> MenuOptions = new List<IMenuOption>()
            {
                new confirmButton(),
                new cancelButton(),
            };

            while (confirmingBuy)
            {
                string title = $"Are you sure you want to buy {item.Name} for {item.price}g?";
                IMenuOption selected = ConsoleMenu.Show(title, MenuOptions);

                if (selected is confirmButton)
                {
                    SellItemToChararacter(item, character);
                    confirmingBuy = false;;
                }
                else if (selected is cancelButton)
                {
                    confirmingBuy = false;
                }
            }


        }

        class confirmButton : IMenuOption
        {
            public string DisplayName => "Confirm";
        }
        
        class cancelButton : IMenuOption
        {
            public string DisplayName => "Cancel";
        }

        public void EnterShop(Character character)
        {
            var MenuOptions = new List<IMenuOption>();

            // adding all items
            MenuOptions.AddRange(stock.Select(item => new ShopItemOption(item)));

            //adding leave button
            MenuOptions.Add(new leaveShopOption());

            bool inShop = true;
            while (inShop)
            {
                string title = $"You're ina  shop! Current Gold: ${character.Gold}g";

                // draw menu and get selected option
                IMenuOption selected = ConsoleMenu.Show(title, MenuOptions);

                if (selected is ShopItemOption itemOption)
                {

                    if (itemOption.Item.price > character.Gold)
                    {
                        Console.WriteLine($"You're missing {itemOption.Item.price - character.Gold}g!");
                        Console.ReadKey();
                    }
                    else
                    {
                        PurchaseConfirmation(itemOption.Item, character);
                    }

                }
                else if (selected is leaveShopOption)
                {
                    inShop = false;
                }
                
                // after leaving the shop, the game loop should show the regular navigation options
            } 
        }

        interface IMenuOption
        {
            string DisplayName { get; }
        }

        class ShopItemOption : IMenuOption
        {
            public Item Item { get; }
            public string DisplayName => $"{Item.Name} {Item.price}g";
            public ShopItemOption(Item item) { Item = item; }
        }

        class leaveShopOption : IMenuOption
        {
            public string DisplayName => "Leave Shop";
        }
    }
}
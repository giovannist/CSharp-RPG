
namespace RPG.Items
{

// 001 - Health Potion
public class ConsumableDeclarations()
{
    public Item? GetConsumable(int id, int amount)
    {
        switch (id)
        {
            case 001:
                return new HealthPotion("Health Potion", amount, 4, 10);
            default:
                Console.WriteLine("Couldn't find item");
                break;
        }
        return null;
    }
}
    public class ArmorDeclarations()
    {
        public Item? GetArmor(int id, int amount)
        {
            switch (id)
            {
                default:
                    Console.WriteLine("Couldn't find item");
                    break;
            }
            return null;
        }
    }    

}

using RPG.Enemies;
using RPG.Core;
using RPG.UI;
using System.Threading.Tasks;

namespace RPG.World
{
    public abstract class Battle : Location
    {
        public override string Name => "";
        private IReadOnlyList<Location> options = new List<Location>();
        public override IReadOnlyList<Location> Options => options;

        public async Task EnterBattle(Character player, Enemy enemy)
        {
            var MenuOptions = new List<IMenuOption>();
            MenuOptions.Add(new AttackOption());
            MenuOptions.Add(new InventoryOption());
            MenuOptions.Add(new FleeOption());

            bool inBattle = true;
            bool isPlayerTurn = true;
            string log = "";
            while (inBattle)
            {
                if (isPlayerTurn)
                {
                    IMenuOption selected = ConsoleMenu.BattleInterface(player, enemy, MenuOptions, log);

                    if (selected is FleeOption)
                    {
                        inBattle = false;
                    }
                    else if (selected is AttackOption)
                    {
                        enemy.health -= player.stats.MaxDamage;
                        log = $"player dealt {player.stats.MaxDamage} damage!";
                    }
                    else if (selected is InventoryOption)
                    {
                    }
                }
                var title = "abcdefg";


            } 
        }

        public interface IMenuOption
        {
            string DisplayName { get; }
        }

        class AttackOption : IMenuOption
        {
            public string DisplayName => "Attack";
        }
        
        class InventoryOption: IMenuOption
        {
            public string DisplayName => "Inventory";
        }
        class FleeOption : IMenuOption
        {
            public string DisplayName => "Flee";
        }
    }
}
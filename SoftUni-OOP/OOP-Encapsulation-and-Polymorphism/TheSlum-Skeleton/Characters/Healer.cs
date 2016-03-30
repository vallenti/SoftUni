using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Healer : Character, IHeal
    {

        private const int DefaultHealth = 75;
        private const int DefaultDefence = 50;
        private const int DefaultHeal = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : this(id, x, y, DefaultHealth, DefaultDefence,DefaultHeal, team, DefaultRange)
        {
        }

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, int healingPoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }
        

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .OrderBy(t => t.HealthPoints)
                .FirstOrDefault(ch => ch.Team == this.Team && ch.IsAlive && ch != this);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString()+", Healing: "+this.HealingPoints;
        }
    }
}

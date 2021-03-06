﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Warrior : Character, IAttack
    {
        private const int DefaultHealth = 200;
        private const int DefaultDefence = 100;
        private const int DefaultAttack = 150;
        private const int DefaultRange = 2;


        public Warrior(string id, int x, int y, Team team)
            : this(id, x, y, DefaultHealth, DefaultDefence, DefaultAttack, team, DefaultRange)
        {
        }

        public Warrior(string id, int x, int y, int healthPoints, int defensePoints, int attackPoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(ch => ch.Team != this.Team && ch.IsAlive && ch != this);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}

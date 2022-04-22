using MandatoryAWC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MandatoryAWC.Items.Base
{
    public class ItemBase : IItem
    {
        public string Description { get; }
        public int Damage { get; }
        public int DamageReduction { get; }
        public ItemCategory Category { get; }

        public ItemBase(string description, int damage, int DamageReduction, ItemCategory category)
        {
            Description = description;
            Damage = damage;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Description} {this.GetType().Name} gives {Damage} damage and {DamageReduction} % damage reduction";
        }
    }
}

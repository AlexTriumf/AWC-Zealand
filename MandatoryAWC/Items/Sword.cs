using MandatoryAWC.Items.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAWC.Items
{
    public class Sword : AttackItemBase
    {
        public Sword(string description, int damage, int damagereduction)
            : base(description, damage, damagereduction)
        { }
    }
}

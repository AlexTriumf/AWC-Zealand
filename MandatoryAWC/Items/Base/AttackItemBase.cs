using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAWC.Items.Base
{
    public class AttackItemBase : ItemBase
    {
        public AttackItemBase(string description, int damage, int damagereduction)
            : base(description, damage, damagereduction , ItemCategory.AttackItem)
            { }
    }
}

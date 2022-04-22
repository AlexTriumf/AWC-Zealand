using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAWC.Items.Base
{
    public class DefenseItemBase : ItemBase
    {
        public DefenseItemBase(string description, int damage, int damageReduction)
            : base(description, damage, damageReduction, ItemCategory.DefenseItem)
            { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAWC
{
    public class Creature
    {
        public int HealthPoints { get; set; }
        public string Name { get; set; }
        public bool Dead
        {
            get { return HealthPoints <= 0; }
        }

        

        public void ReceieveDamage(int damagePoints)
        {
            HealthPoints = HealthPoints - damagePoints;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    abstract class Weapon:Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected int name;

        public int Damage
        {
            get { return damage; }
        }

        public int Range
        {
            get { return range; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    abstract class Item:Tile
    {
        public Item(int x, int y) : base(x, y, TILETYPE.ITEM)
        {

        }

        public abstract override string ToString();
        

        
    }
}

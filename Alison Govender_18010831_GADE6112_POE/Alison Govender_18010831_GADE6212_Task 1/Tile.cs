using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public abstract class Tile
    {
        protected int x;
        protected int y;

        protected TILETYPE tileType;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public TILETYPE TileType
        {
            get { return tileType; }
        }

        public Tile(int x,int y,TILETYPE tileType)
        {
            this.x = x;
            this.y = y;
            this.tileType = tileType;
        }
    }

    public enum TILETYPE
    {
        HERO,
        ENEMY,
        GOLD,
        WEAPEN,
        OBSTACLE,
        EMPTY,
        ITEM,
    }
}

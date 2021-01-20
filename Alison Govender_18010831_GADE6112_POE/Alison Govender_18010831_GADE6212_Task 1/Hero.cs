using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Hero:Character
    {
        public Hero(int x,int y,int HP) : base(x, y,TILETYPE.HERO)
        {
            this.Damage = 2;
            
        }

        public override MOVEMENT ReturnMove(MOVEMENT move = 0)
        {
            int dir = (int) move-1;
            Tile tile = vision[dir];

           if(tile != null)
            {
                if(tile.TileType == TILETYPE.EMPTY || tile.TileType == TILETYPE.ITEM)
                {
                    return move;
                }
            }
            return MOVEMENT.NO_MOVEMNET;
        }

        public override string ToString()
        {
            return "Player stats: \n" +
                "HP: " + HP + "/" + maxHP + "\n" +
                "Damage: " + Damage + "\n" + 
                "Gold: " + goldPurse + "\n" +
                "[" + x +" , " + y +" ]";
        }

    }
}

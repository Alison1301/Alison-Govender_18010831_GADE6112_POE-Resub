using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Goblim:Enemy
    {
        public Goblim(int x,int y) : base(x, y,1,10)
        {

        }

        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.NO_MOVEMNET)
        {
            int dir = random.Next(1, 5);

            int maxTries = 10;
            int tries = 0;

            while (vision[dir-1].tileType != TILETYPE.EMPTY && tries < maxTries)
            {
                dir = random.Next(1, 5);
                tries++;

                if(tries == maxTries)
                {
                    return MOVEMENT.NO_MOVEMNET;
                }
            }

            return (MOVEMENT)dir; 
        }
    }
}

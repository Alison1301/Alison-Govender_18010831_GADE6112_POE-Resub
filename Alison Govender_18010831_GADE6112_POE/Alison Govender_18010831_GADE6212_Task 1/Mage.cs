using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Mage : Enemy
    {
        public Mage(int x, int y, int Damage, int HP) : base(x, y, 5, 5);


        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.NO_MOVEMNET)
        {

            return MOVEMENT.NO_MOVEMNET;
        }

        public override bool CheckRange(Character target)
        {
            for (int tx = -1; tx <= 1; tx++)
            {
                for (int ty = -1; ty <= 1; ty++)
                {
                    if (tx == x && ty == y)
                    {
                        continue;
                    }
                   
                   if (target.X == x+ tx && target.Y == y+ ty)
                   {
                       return true;
                   }
                    
                }

            }
            return false;
        }
    }
}

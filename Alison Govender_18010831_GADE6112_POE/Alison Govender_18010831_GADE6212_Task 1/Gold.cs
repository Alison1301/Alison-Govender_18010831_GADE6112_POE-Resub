using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Gold:Item
    {
        private int goldAmount;
        static Random random = new Random();

        private int GoldAmount
        {
            get { return goldAmount; }
        }

        public Gold(int x,int y) : base(x, y)
        {
            goldAmount = random.Next(1, 6);
        }

        public override string ToString()
        {
            return "";
        }

    }
}

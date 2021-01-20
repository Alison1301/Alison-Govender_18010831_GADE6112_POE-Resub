using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Game_Engine
    {
        Map map;

        public string View
        {
            get { return map.ToString(); }
        }

        public string HeroStats
        {
            get{ return map.Hero.ToString(); }
        }

        public Game_Engine()
        {
            map = new Map(6, 12, 6, 12, 10);
        }

        public string Map
        {
            get { return map.ToString(); }
        }

        

        public  bool MovePlayer(Movemet desiredMovE)
        {
            Movement allowedMove = map.Hero.ReturnMove(desiredMove);
            Debug.WriteLine(allowedMove);
            map.Hero.Move(allowedMove);
            EnemiesMove();
            map.Update();

            Item item = map.GetItemAtPosition(map.Hero.X, map.Hero.Y);
            if (item == null)
            {
                map.Hero.Pickup(item);
            }

            map.Update();

            if(allowedMove == Movement.NO_MOVEMENT)
            {
                return false;
            }

            return true;
        }

        

        public string PlayerAttack(AttackDirection direction)
        {
            int visionIndex = (int)direction;
            string failMessage = "Hero attack failed";

            if(map.Hero.Vision[visionIndex ]== TILETYPE.ENEMY)
            {
                Enemy enemy = (Enemy)map.Hero.Vision[visionIndex];
                if (enemy.IsDead())
                {
                    return failMessage;
                }

                map.Hero.Attack(enemy);
                map.Update();

                if (enemy.IsDead())
                {
                    return "Hero killed Enemy";
                }

                return "Hero attacked Enemy\n" +
                    "Enemy HP: " + enemy.hp + "/" + enemy.maxHP;
            }

            return failMessage;
        }

        public void EnemiesMove()
        {
            foreach(Enemy enemy in map.Enemies)
            {
                Movement allowedMove = enemy.ReturnMove(desiredMove);
                enemy.Move(allowedMove);
            }
        }

        public void EnemiesAttack()
        {
            foreach (Enemy enemy in map.Enemies)
            {
                
            }
        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}

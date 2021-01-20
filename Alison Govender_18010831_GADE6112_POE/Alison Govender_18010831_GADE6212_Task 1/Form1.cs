using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public partial class GoblimsGame_Frm : Form
    {

        Game_Engine game_Engine;


        public GoblimsGame_Frm()
        {
            game_Engine = new Game_Engine();
            Tile_Lbl.Text = game_Engine.View;
            BattleInfo_Lbl.Text = game_Engine.HeroStats;

            InitializeComponent();
      
        }

        private void GoblimsGame_Frm_Load(object sender, EventArgs e)
        {
            Tile_Lbl.Text = game_Engine.View;
            BattleInfo_Lbl.Text = game_Engine.HeroStats;
        }

       private void GoblimsGame_Frm_KeyPress(object sender,EventArgs e)
       {

       }

        private void MoveUp()
        {
            game_Engine.MovePlayer(Movement.UP);
            Tile_Lbl.Text = game_Engine.View;
            BattleInfo_Lbl.Text = game_Engine.HeroStats;
        }
        private void MoveLeft()
        {
            game_Engine.MovePlayer(Movement.LEFT);
            Tile_Lbl.Text = game_Engine.View;
            BattleInfo_Lbl.Text = game_Engine.HeroStats;
        }
        private void MoveDown()
        {
            game_Engine.MovePlayer(Movement.DOWM);
            Tile_Lbl.Text = game_Engine.View;
            BattleInfo_Lbl.Text = game_Engine.HeroStats;
        }
        private void MoveRight()
        {
            game_Engine.MovePlayer(Movement.RIGHT);
            Tile_Lbl.Text = game_Engine.View;
            BattleInfo_Lbl.Text = game_Engine.HeroStats;
        }

        private void AttackUp()
        {
            BattleInfo_Lbl.Text = game_Engine.PlayerAttack(AttackDirection.UP);
            Tile_Lbl.Text = game_Engine.View;
        }

        private void AttackDown()
        {
            BattleInfo_Lbl.Text = game_Engine.PlayerAttack(AttackDirection.DOWN);
            Tile_Lbl.Text = game_Engine.View;
        }
    }
    }
}

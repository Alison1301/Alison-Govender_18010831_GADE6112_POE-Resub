namespace Alison_Govender_18010831_GADE6212_Task_1
{
    partial class GoblimsGame_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tile_Lbl = new System.Windows.Forms.Label();
            this.BattleInfo_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tile_Lbl
            // 
            this.Tile_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tile_Lbl.Location = new System.Drawing.Point(74, 37);
            this.Tile_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tile_Lbl.Name = "Tile_Lbl";
            this.Tile_Lbl.Size = new System.Drawing.Size(321, 473);
            this.Tile_Lbl.TabIndex = 0;
            this.Tile_Lbl.Text = "NO MAP";
            this.Tile_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleInfo_Lbl
            // 
            this.BattleInfo_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BattleInfo_Lbl.Location = new System.Drawing.Point(508, 55);
            this.BattleInfo_Lbl.Name = "BattleInfo_Lbl";
            this.BattleInfo_Lbl.Size = new System.Drawing.Size(383, 188);
            this.BattleInfo_Lbl.TabIndex = 1;
            // 
            // GoblimsGame_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.BattleInfo_Lbl);
            this.Controls.Add(this.Tile_Lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GoblimsGame_Frm";
            this.Text = "Goblim game";
            this.Load += new System.EventHandler(this.GoblimsGame_Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Tile_Lbl;
        private System.Windows.Forms.Label BattleInfo_Lbl;
    }
}


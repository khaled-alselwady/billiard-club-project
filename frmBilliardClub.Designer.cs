namespace Billiard_Club_Project
{
    partial class frmBilliardClub
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucPoolTable1 = new Billiard_Club_Project.ucPoolTable();
            this.ucPoolTable2 = new Billiard_Club_Project.ucPoolTable();
            this.ucPoolTable3 = new Billiard_Club_Project.ucPoolTable();
            this.ucPoolTable4 = new Billiard_Club_Project.ucPoolTable();
            this.ucPoolTable5 = new Billiard_Club_Project.ucPoolTable();
            this.ucPoolTable6 = new Billiard_Club_Project.ucPoolTable();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1138, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "Billiard Club";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucPoolTable1
            // 
            this.ucPoolTable1.HourlyRate = 10F;
            this.ucPoolTable1.Location = new System.Drawing.Point(12, 171);
            this.ucPoolTable1.Name = "ucPoolTable1";
            this.ucPoolTable1.PlayerName = "Player";
            this.ucPoolTable1.Size = new System.Drawing.Size(352, 288);
            this.ucPoolTable1.TabIndex = 6;
            this.ucPoolTable1.TableName = "Table";
            this.ucPoolTable1.OnRoundComplete += new System.EventHandler<Billiard_Club_Project.ucPoolTable.PoolTableEventHandler>(this.ucPoolTable1_OnRoundComplete_1);
            // 
            // ucPoolTable2
            // 
            this.ucPoolTable2.HourlyRate = 10F;
            this.ucPoolTable2.Location = new System.Drawing.Point(397, 171);
            this.ucPoolTable2.Name = "ucPoolTable2";
            this.ucPoolTable2.PlayerName = "Player";
            this.ucPoolTable2.Size = new System.Drawing.Size(352, 288);
            this.ucPoolTable2.TabIndex = 7;
            this.ucPoolTable2.TableName = "Table";
            this.ucPoolTable2.OnRoundComplete += new System.EventHandler<Billiard_Club_Project.ucPoolTable.PoolTableEventHandler>(this.ucPoolTable1_OnRoundComplete_1);
            // 
            // ucPoolTable3
            // 
            this.ucPoolTable3.HourlyRate = 10F;
            this.ucPoolTable3.Location = new System.Drawing.Point(777, 171);
            this.ucPoolTable3.Name = "ucPoolTable3";
            this.ucPoolTable3.PlayerName = "Player";
            this.ucPoolTable3.Size = new System.Drawing.Size(352, 288);
            this.ucPoolTable3.TabIndex = 8;
            this.ucPoolTable3.TableName = "Table";
            this.ucPoolTable3.OnRoundComplete += new System.EventHandler<Billiard_Club_Project.ucPoolTable.PoolTableEventHandler>(this.ucPoolTable1_OnRoundComplete_1);
            // 
            // ucPoolTable4
            // 
            this.ucPoolTable4.HourlyRate = 10F;
            this.ucPoolTable4.Location = new System.Drawing.Point(777, 487);
            this.ucPoolTable4.Name = "ucPoolTable4";
            this.ucPoolTable4.PlayerName = "Player";
            this.ucPoolTable4.Size = new System.Drawing.Size(352, 288);
            this.ucPoolTable4.TabIndex = 11;
            this.ucPoolTable4.TableName = "Table";
            this.ucPoolTable4.OnRoundComplete += new System.EventHandler<Billiard_Club_Project.ucPoolTable.PoolTableEventHandler>(this.ucPoolTable1_OnRoundComplete_1);
            // 
            // ucPoolTable5
            // 
            this.ucPoolTable5.HourlyRate = 10F;
            this.ucPoolTable5.Location = new System.Drawing.Point(397, 487);
            this.ucPoolTable5.Name = "ucPoolTable5";
            this.ucPoolTable5.PlayerName = "Player";
            this.ucPoolTable5.Size = new System.Drawing.Size(352, 288);
            this.ucPoolTable5.TabIndex = 10;
            this.ucPoolTable5.TableName = "Table";
            this.ucPoolTable5.OnRoundComplete += new System.EventHandler<Billiard_Club_Project.ucPoolTable.PoolTableEventHandler>(this.ucPoolTable1_OnRoundComplete_1);
            // 
            // ucPoolTable6
            // 
            this.ucPoolTable6.HourlyRate = 10F;
            this.ucPoolTable6.Location = new System.Drawing.Point(12, 487);
            this.ucPoolTable6.Name = "ucPoolTable6";
            this.ucPoolTable6.PlayerName = "Player";
            this.ucPoolTable6.Size = new System.Drawing.Size(352, 288);
            this.ucPoolTable6.TabIndex = 9;
            this.ucPoolTable6.TableName = "Table";
            this.ucPoolTable6.OnRoundComplete += new System.EventHandler<Billiard_Club_Project.ucPoolTable.PoolTableEventHandler>(this.ucPoolTable1_OnRoundComplete_1);
            // 
            // frmBilliardClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 787);
            this.Controls.Add(this.ucPoolTable4);
            this.Controls.Add(this.ucPoolTable5);
            this.Controls.Add(this.ucPoolTable6);
            this.Controls.Add(this.ucPoolTable3);
            this.Controls.Add(this.ucPoolTable2);
            this.Controls.Add(this.ucPoolTable1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBilliardClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billiard Club";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ucPoolTable ucPoolTable1;
        private ucPoolTable ucPoolTable2;
        private ucPoolTable ucPoolTable3;
        private ucPoolTable ucPoolTable4;
        private ucPoolTable ucPoolTable5;
        private ucPoolTable ucPoolTable6;
    }
}


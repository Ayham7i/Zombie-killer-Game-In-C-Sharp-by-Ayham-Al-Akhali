namespace zombie_killer_by_Ayham
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.Health = new System.Windows.Forms.Label();
            this.kills = new System.Windows.Forms.Label();
            this.Ammo = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(731, 8);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(181, 24);
            this.healthbar.TabIndex = 9;
            this.healthbar.Value = 100;
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.BackColor = System.Drawing.Color.DarkGray;
            this.Health.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(652, 8);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(73, 23);
            this.Health.TabIndex = 8;
            this.Health.Text = "Health";
            // 
            // kills
            // 
            this.kills.AutoSize = true;
            this.kills.BackColor = System.Drawing.Color.DarkGray;
            this.kills.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kills.ForeColor = System.Drawing.Color.White;
            this.kills.Location = new System.Drawing.Point(373, 9);
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(82, 23);
            this.kills.TabIndex = 7;
            this.kills.Text = "Kills : 0";
            // 
            // Ammo
            // 
            this.Ammo.AutoSize = true;
            this.Ammo.BackColor = System.Drawing.Color.DarkGray;
            this.Ammo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ammo.ForeColor = System.Drawing.Color.White;
            this.Ammo.Location = new System.Drawing.Point(12, 9);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(102, 23);
            this.Ammo.TabIndex = 6;
            this.Ammo.Text = "Ammo : 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.Image = global::zombie_killer_by_Ayham.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(399, 306);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.kills);
            this.Controls.Add(this.Ammo);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label kills;
        private System.Windows.Forms.Label Ammo;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
    }
}


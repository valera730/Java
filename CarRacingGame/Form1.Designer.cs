namespace CarRacingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.over = new System.Windows.Forms.Label();
            this.coins1 = new System.Windows.Forms.PictureBox();
            this.coins2 = new System.Windows.Forms.PictureBox();
            this.coinsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(167, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Location = new System.Drawing.Point(168, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 90);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Location = new System.Drawing.Point(167, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 89);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Location = new System.Drawing.Point(168, 303);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(9, 101);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Location = new System.Drawing.Point(2, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 464);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Location = new System.Drawing.Point(371, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 464);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Location = new System.Drawing.Point(167, 423);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(9, 101);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(49, 353);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(43, 64);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 1;
            this.car.TabStop = false;
            this.car.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(31, 146);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(43, 64);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            this.enemy1.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(205, 83);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(43, 64);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 1;
            this.enemy3.TabStop = false;
            this.enemy3.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // enemy4
            // 
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(285, 271);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(43, 64);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 1;
            this.enemy4.TabStop = false;
            this.enemy4.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(101, 24);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(43, 64);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 1;
            this.enemy2.TabStop = false;
            this.enemy2.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(101, 220);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(139, 32);
            this.over.TabIndex = 2;
            this.over.Text = "Game Over";
            this.over.Click += new System.EventHandler(this.label1_Click);
            // 
            // coins1
            // 
            this.coins1.Image = ((System.Drawing.Image)(resources.GetObject("coins1.Image")));
            this.coins1.Location = new System.Drawing.Point(101, 178);
            this.coins1.Name = "coins1";
            this.coins1.Size = new System.Drawing.Size(28, 32);
            this.coins1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coins1.TabIndex = 1;
            this.coins1.TabStop = false;
            this.coins1.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // coins2
            // 
            this.coins2.BackColor = System.Drawing.Color.Gainsboro;
            this.coins2.Image = ((System.Drawing.Image)(resources.GetObject("coins2.Image")));
            this.coins2.Location = new System.Drawing.Point(266, 166);
            this.coins2.Name = "coins2";
            this.coins2.Size = new System.Drawing.Size(28, 32);
            this.coins2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coins2.TabIndex = 1;
            this.coins2.TabStop = false;
            this.coins2.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // coinsLabel
            // 
            this.coinsLabel.AutoSize = true;
            this.coinsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coinsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.coinsLabel.Location = new System.Drawing.Point(18, 24);
            this.coinsLabel.Name = "coinsLabel";
            this.coinsLabel.Size = new System.Drawing.Size(82, 25);
            this.coinsLabel.TabIndex = 3;
            this.coinsLabel.Text = "Coins=0";
            this.coinsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.coinsLabel);
            this.Controls.Add(this.coins2);
            this.Controls.Add(this.coins1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "CarRacingGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.car_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox coins1;
        private System.Windows.Forms.PictureBox coins2;
        private System.Windows.Forms.Label coinsLabel;
    }
}


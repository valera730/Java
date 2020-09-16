using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinsCollection();
        }

        Random r = new Random();
        int x, y;
        int collectedPoint = 0;

        void coinsCollection()
        {
            if(car.Bounds.IntersectsWith(coins1.Bounds))
            {
                collectedPoint++;
                coinsLabel.Text = "Coins=" + collectedPoint.ToString();

                x = r.Next(50, 300);
                coins1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coins2.Bounds))
            {
                collectedPoint++;
                coinsLabel.Text = "Coins=" + collectedPoint.ToString();

                x = r.Next(50, 300);
                coins2.Location = new Point(x, 0);
            }
        }

        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,150);
                enemy1.Location = new Point(x,0);
            }
            else
                enemy1.Top += speed;

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
                enemy2.Top += speed;
            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else
                enemy3.Top += speed;
            if (enemy4.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy4.Location = new Point(x, 0);
            }
            else
                enemy4.Top += speed;
        }
        void coins(int speed)
        {
            if (coins1.Top >= 500)
            {
                x = r.Next(0, 200);
                coins1.Location = new Point(x, 0);
            }
            else
                coins1.Top += speed;
            if (coins2.Top >= 500)
            {
                x = r.Next(0, 200);
                coins2.Location = new Point(x, 0);
            }
            else
                coins2.Top += speed;
        }

        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds)|| car.Bounds.IntersectsWith(enemy3.Bounds)|| car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
                pictureBox1.Top = 0;
            else
                pictureBox1.Top += speed;

            if (pictureBox2.Top >= 500)
                pictureBox2.Top = 0;
            else
                pictureBox2.Top += speed;

            if (pictureBox3.Top >= 500)
                pictureBox3.Top = 0;
            else
                pictureBox3.Top += speed;

            if (pictureBox4.Top >= 500)
                pictureBox4.Top = 0;
            else
                pictureBox4.Top += speed;

            if (pictureBox7.Top >= 500)
                pictureBox7.Top = 0;
            else
                pictureBox7.Top += speed;

            /*pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
            pictureBox7.Top += speed;*/
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        int gamespeed = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void car_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left>0)
                    car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<380)
                    car.Left +=8;
            }
            if (e.KeyCode == Keys.Up)
                if (gamespeed < 21)
                    gamespeed++;
            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                    gamespeed--;
        }
    }
}

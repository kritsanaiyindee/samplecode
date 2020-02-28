using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FarmerRun
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpspeed=20;
        int force = 2;
            int score=0;
        int obstaclespeed=20;
        Random r=new Random();
        Stopwatch s1;
        public Form1()
        {
            InitializeComponent();
            s1 = new Stopwatch();
            s1.Start();
            timer1.Start();
            label2.Text = "จับเวลา   :" + s1.Elapsed.Minutes + ":" + s1.Elapsed.Seconds;
            label2.Visible = true;
        }
        int cnt = 0;
        private void gameEvent(object sender, EventArgs e)
        {
            //  label1.Text = "จับเวลา   :" + s1.Elapsed.ToString("hh\\:mm\\:ss");
            label2.Text = "จับเวลา   :" + s1.Elapsed.Minutes + ":" + s1.Elapsed.Seconds;
            farmer.Top += jumpspeed;
            label1.Text = " คะแนน: " + score;
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (jumping)
            {
                jumpspeed = -12;
                force -= 1;
            }
            else
            {
                jumpspeed = 12;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;
                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + r.Next(100, 400);
                      //  score++;
                    }
                    if (farmer.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        farmer.Image = Properties.Resources.running2;

                        label1.Text = " จบเกมส์";
                    }
                    
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    x.Left -= obstaclespeed;
                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + r.Next(100, 400);
                     //   x.Width = 57;
                     //   x.Height =49;
                      //  score++;
                    }
                    if (farmer.Bounds.IntersectsWith(x.Bounds))
                    {
                      //  timer1.Stop();
                      //  farmer.Image = Properties.Resources.dead;
                        
                        if (cnt == 0)
                        {
                            score += 10;
                            cnt++;
                        }
                        else if (cnt == 15)
                        {
                            cnt = 0;
                        }
                        else
                        {
                            cnt++;
                        }
                        label1.Text = " คะแนน: " + score;
                        
                      //  x.Width=0;
                      //  x.Height = 0;
                       
                      //  label1.Text += " Press R to restart";
                    }

                }
            }
            if (farmer.Top >= 380 && !jumping)
            {
                force = 12;
                farmer.Top = floor.Top - farmer.Height;
                jumpspeed = 0;
            }
            if (score >= 10)
            {
                obstaclespeed = 15;
            }

        }

        private void FKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void FKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R )
            {
                ResetGame();
            }
            if (jumping)
            {
                jumping = false;
            }
        }
        public void ResetGame(){
            if (s1.Elapsed.Minutes == 3)
            {
                timer1.Stop();
                s1.Stop();
              //  button5.Visible = true;
            }



            force = 12;
            farmer.Top = floor.Top - farmer.Height;
            jumpspeed = 0;
            jumping = false;
            score = 0;
            obstaclespeed = 10;
            label1.Text = " คะแนน: " + score;
            farmer.Image = Properties.Resources.running2;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    int position =  r.Next(100, 400);
                    x.Left = 250 + (x.Left + position + x.Width * 3);
                    x.Left -= obstaclespeed;
                   
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    int position = r.Next(100, 400);
                    x.Left = 250 + (x.Left + position + x.Width * 3);
                    x.Left -= obstaclespeed;

                }
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetGame();
            


            //if (true)
            //{
            //    MessageBox.Show("Game Over", "Alert", MessageBoxButtons.OK);
            //    this.Dispose();//ปิดหน้าจอ
            //}
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Credit();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Howto();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }
    }
}

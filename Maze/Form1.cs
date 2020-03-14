using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maze.Properties;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i=60;
        Color[] mycolorleft = new Color[19];
        Color[] mycolorup = new Color[19];
        Color[] mycolorright = new Color[19];
        Color[] mycolordown = new Color[19];

        public bool UP()//建立一个类用于判断是否是墙
        {
            Bitmap map = new Bitmap(Map.Image);
            for (int i = 0; i < 19; i++)
            {
                mycolorup[i] = map.GetPixel(rat.Left + i, rat.Top - 13);
            }
            for (int a = 0; a < 19; a++)
            {
                if (mycolorup[a].ToArgb() != Color.White.ToArgb())//用循环判断是否有任意一个点不为通道；                                                             
                {
                    return false;
                }
            }
            return true;
        }
        public bool down()
        {
            Bitmap bitmap = new Bitmap(Map.Image);
            for (int i = 0; i < 19; i++)
            { 
                mycolordown[i] = bitmap.GetPixel(rat.Left + i, rat.Top + 9); 
            }
            for (int a = 0; a < 19; a++)
            {
                if (mycolordown[a].ToArgb() != Color.White.ToArgb())
                {
                    return false;
                }
            }
            return true;
        }
        public bool left()
        {
            Bitmap bitmap = new Bitmap(Map.Image);
            for (int i = 0; i < 19; i++)
            {
                mycolorleft[i] = bitmap.GetPixel(rat.Left -12, rat.Top + i);
            }
            for (int a = 0; a < 19; a++)
            {
                if (mycolorleft[a].ToArgb() != Color.White.ToArgb())
                {
                    return false;
                }
            }
            return true;
        }
        public bool right()
        {
            Bitmap bitmap = new Bitmap(Map.Image);
            for (int i = 0; i < 19; i++)
            {
                mycolorright[i] = bitmap.GetPixel(rat.Left + 10, rat.Top + i);
            }
            for (int a = 0; a < 19; a++)
            {
                if (mycolorright[a].ToArgb() != Color.White.ToArgb())
                {
                    return false;
                }
            }
            return true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            lblTime.Text = "时间剩余：" + i + "秒";           
            if (i == 0)
            {
                timer1.Stop();
                 DialogResult result=MessageBox.Show("时间已到，您没能在规定的时间内到达终点！", "游戏结束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                 if (result == DialogResult.Cancel)
                 {
                     Application.Exit();
                 }
                 else 
                 {
                     i = 60;
                     Map.Image = Resources.mapMaze;
                     timer1.Start();
                     rat.Left = 441;
                     rat.Top = 317;
                 }
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                if (UP())
                {
                    rat.Top -= 2;
                }
            }
            if (keyData == Keys.Down)
            {
                if (down())
                {
                    rat.Top += 2;
                }
            }
            if (keyData == Keys.Left)
            {
                if (rat.Left <= 20)//当老鼠到达终点时，检测它离右边的距离；
                {

                    win.Visible = true;
                    timer1.Stop();
                    rat.Enabled = false;
                    DialogResult result=MessageBox.Show("恭喜你，闯关成功","你赢了",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                    if (result == DialogResult.Retry)
                    {
                        i = 60;
                        rat.Enabled = true;
                        timer1.Start();
                        win.Visible = false;
                        rat.Left = 441;
                        rat.Top = 317;
                    }
                    else
                    {
                        Application.Exit();
                    }

                }
                if (left() && rat.Left >= 0)
                {
                    rat.Left -= 2;
                }
            }
            if (keyData == Keys.Right)
            {
                if (right() && rat.Left <= 440)
                {
                    rat.Left += 2;
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            i = 60;
            timer1.Start();
            rat.Left = 441;
            rat.Top = 317;
            Map.Image = Resources.mapMaze2;            
        }
    }
}

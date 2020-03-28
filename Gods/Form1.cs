using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Gods
{
    
    public partial class Form1 : Form
    {

        int count = 0;
        Random rnd = new Random();
        PictureBox[] allp;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            buildpicture(40);
            Shuffle();
            showboard(5, 8);
            turnofpl.Text = 1 + "";
        }

        private void Shuffle()
        {
            int num;
            PictureBox tmp;
            for (int i = 0; i < allp.Length; i++)
            {
                num = rnd.Next(0, allp.Length);
                tmp = allp[i];
                allp[i] = allp[num];
                allp[num] = tmp;
            }
        }

        private void showboard(int row, int col)
        {
            int x = 85, y = 85;
            int place = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    allp[place].Image = (Image)Properties.Resources.ResourceManager.GetObject("opening");
                    allp[place].Location = new Point(x, y);
                    x += 85;
                    Controls.Add(allp[place++]);

                }
                x = 85;
                y += 85;
            }
        }
        private void buildpicture(int size)
        {
            int picnum = 1;
            allp = new PictureBox[size];
            for (int i = 0; i < allp.Length - 1; i += 2)
            {
                allp[i] = new PictureBox();
                allp[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("god" + (picnum));
                allp[i].Size = new Size(80, 80);
                allp[i].SizeMode = PictureBoxSizeMode.StretchImage;
                allp[i].BorderStyle = BorderStyle.FixedSingle;
                allp[i].Tag = picnum + "";
                allp[i].Click += allp_Click;

                allp[i + 1] = new PictureBox();
                allp[i + 1].Tag = picnum + "";
                allp[i + 1].Image = (Image)Properties.Resources.ResourceManager.GetObject("god" + (picnum++));
                allp[i + 1].Size = new Size(80, 80);
                allp[i + 1].SizeMode = PictureBoxSizeMode.StretchImage;
                allp[i + 1].BorderStyle = BorderStyle.FixedSingle;

                allp[i + 1].Click += allp_Click;

            }

        }
        PictureBox[] arrpic = new PictureBox[2];
        int nikod = 0, nikod2 = 0;
        bool turnwho = true;

        int time = 5;
        private void allp_Click(object sender, EventArgs e)
        {
            
                PictureBox p = (PictureBox)sender;

                p.Image = (Image)Properties.Resources.ResourceManager.GetObject("god" + (p.Tag));
                tmr.Enabled = true;
                count++;
            
            

                //Timer timer = new Timer(new TimerCallback(timerCb), null, 2000, 0);

                arrpic[count - 1] = p;


                if (count == 2)
                {
                    count = 0;
               
                if (arrpic[0].Tag.Equals(arrpic[1].Tag))
                {
                   
                    for (int i = 0; i < 2; i++)
                    {

                        arrpic[i].Visible = false;
                        arrpic[i] = null;

                    }
                    if (turnwho == true)
                    {
                        nikod++;
                        first.Text = nikod + "";
                    }
                    else
                    {
                        nikod2++;
                        second.Text = nikod2 + "";
                    }
                }

                else
                {
                  
                    for (int i = 0; i < 2; i++)
                    {
                       
                        Turn(arrpic[i]);
                       arrpic[i] = null;

                    }

                }
                    turnwho = !turnwho;//הופך שחקן
                    if (turnwho == true)
                        turnofpl.Text = 1 + "";
                    else
                        turnofpl.Text = 2 + "";
                }



            
        }

        private void Line_Click(object sender, EventArgs e)
        {

        }

        private void First_Click(object sender, EventArgs e)
        {

        }

        private void Scr1_Click(object sender, EventArgs e)
        {

        }

        private void Second_Click(object sender, EventArgs e)
        {

        }

        private void Scr2_Click(object sender, EventArgs e)
        {

        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            
            if (time == -1)
                tmr.Enabled = false;
           else
               time--;
            
        }

        public void Turn(PictureBox p)
        {
            p.Image = Properties.Resources.opening;
        }


       

    }
}


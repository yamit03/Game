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

       int time2=1;
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
            int x = 65, y = 150;
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
                x = 65;
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

        int time = 1,count3=0;
        private void allp_Click(object sender, EventArgs e)
        {
            if (!tmr.Enabled )
            {
                PictureBox p = (PictureBox)sender;

                p.Image = (Image)Properties.Resources.ResourceManager.GetObject("god" + (p.Tag));
                
                   
                count++;
         

                arrpic[count - 1] = p;


                if (count == 2)
                {
                    count = 0;
                    time = 1;
                    tmr.Enabled = true;
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


                    turnwho = !turnwho;//הופך שחקן
                    count3++;
                    if (turnwho == true)
                    
                        turnofpl.Text = 1 + "";
                    
                    else
                     
                        turnofpl.Text = 2 + "";
               
                 }

                if(Check()==true)
                {
                    win.Visible = true;
                    if(nikod>nikod2)
                    win.Text = "the winner is PLAYER 1";
                    if (nikod < nikod2)
                        win.Text = "the winner is PLAYER 2";
                    if (nikod == nikod2)
                        win.Text = "Its a TIE";
                }

            }
            
        }

        private void Line_Click(object sender, EventArgs e)
        {

        }
        public bool Check()
        {
            for (int i = 0; i < allp.Length; i++)
            {
                if (allp[i].Visible== true)
                    return false;
            }
            return true;
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
            {
               
                time = 1;
                Turn(arrpic[0]);
                Turn(arrpic[1]);
               tmr.Enabled = false;
            }
            else
                time--;
            
        }

        private void Pboppen_Click(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        public void Turn(PictureBox p)
        {
            if(p!=null)
                p.Image = Properties.Resources.opening;
        }


       

    }
}


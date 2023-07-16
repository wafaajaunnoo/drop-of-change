using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropofchange
{
    public partial class Homepage : MaterialSkin.Controls.MaterialForm
    {
        public Homepage()
        {
            InitializeComponent();
        

        }
        /*image gallery*/
        string[] pics = new string[] { "pic1.jpg", "pic2.jpg","pupil.jpg" };
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //placing the first image in the pictureBox
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "//images//" + pics[0]);
        }

        //slideshow of pictures when timer starts
        private void timer1_Tick(object sender, EventArgs e)
        {
                //incrementing i by one to play next picture
                i += 1;

                //validation for pictures
                if (pics.Length == i)
                {
                    i = 0;
                }

                //to load the image
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "//images//" + pics[i]);            
        }
        //code for the next button to play next picture
        private void btnNext_Click(object sender, EventArgs e)
        {
            //disabling the timer so image stops loading automatically 
            timer1.Enabled = false;

            //to increment picture by 1 when btnNext is clicked
            i += 1;
            if (pics.Length == i)
            {
                i = 0;
            }

            //to load the image
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "//images//" + pics[i]);


            //enabling timer again to reset the image load in 5 seconds
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }
        //code for the prev button to play previous picture
        /* private void btnPrev_Click(object sender, EventArgs e)
        {

            //disabling timer to prevent the next image from loading automatically
            timer1.Enabled = false;
            i -= 1;

            if (pics.Length == i)
            {
                i = 0;

            }

            pictureBox1.Image = Image.FromFile(Application.StartupPath + "//images//" + pics[i]);

            timer1.Enabled = true;
            timer1.Interval = 5000;
        
        }*/

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            admission obj = new admission();
            obj.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            records obj = new records();
            obj.Show();
            this.Hide();
        }

       

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dropofchange
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        public login()
        {
            InitializeComponent();
        }

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

      

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tasne\Documents\Logindata.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username ='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainRecord ss = new MainRecord();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
            
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class records : MaterialSkin.Controls.MaterialForm
    {
        public records()
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
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

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
    public partial class admission : MaterialSkin.Controls.MaterialForm
    {


        public admission()
        {
            InitializeComponent();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            admission obj = new admission();
            obj.Show();
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



        private void appTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txt_student_fname.Clear();
            txt_student_mname.Clear();
            txt_student_lname.Clear();
            rad_student_male.Checked = false;
            rad_student_female.Checked = false;
            dateTimePicker.ResetText();
            txt_student_age.Clear();
            txt_student_address.Clear();
            txt_student_health.Clear();
            chk_LB_hobbies_interests.Text = "";
            student_pic.Image = null;
            while (chk_LB_hobbies_interests.CheckedIndices.Count > 0)
            {
                chk_LB_hobbies_interests.SetItemChecked(chk_LB_hobbies_interests.CheckedIndices[0], false);
            }



        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            //Responsible Party 1
            txt_rp1_lname.Clear();
            txt_rp1_oname.Clear();
            txt_rp1_id.Clear();
            txt_rp1_salary.Clear();
            txt_rp1_occupation.Clear();
            txt_rp1_num.Clear();
            txt_rp1_address.Clear();
            rp1_picture.Image = null;

            //Responsible Party 2
            txt_rp2_lname.Clear();
            txt_rp2_oname.Clear();
            txt_rp2_id.Clear();
            txt_rp2_salary.Clear();
            txt_rp2_occupation.Clear();
            txt_rp2_mobile.Clear();
            txt_rp2_address.Clear();
            rp2_picture.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void circularButton2_Click(object sender, EventArgs e)
        {
           


            //display an error message if the following fields are empty
            if (txt_student_fname.Text == string.Empty ||
                txt_student_mname.Text == string.Empty ||
                txt_student_lname.Text == string.Empty ||
                txt_student_age.Text == string.Empty ||
                txt_student_address.Text == string.Empty)
            {
                MessageBox.Show("Please ensure you fill in all necessary information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //save data in db in fields are filled in
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tasne\Documents\Logindata.mdf;Integrated Security=True;Connect Timeout=30"); //open connection
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into MyStudents(fname,mname,lname,age, address,gender,hobbies_interest, health) values" +
                    "('" + txt_student_fname.Text + "','" +
                           txt_student_mname.Text + "','" +
                           txt_student_lname.Text + "','" +
                           //saving value from dateTimePicker
                           dateTimePicker.Text + "','" +
                           txt_student_age.Text + "','" +
                           txt_student_address.Text + "','" +
                          //saving value for gender (radio buttons)
                           student_gender + "','" +
                           //saving items selected in checkedListBox
                           chk_LB_hobbies_interests.Text + "','" +
                           txt_student_health.Text + "')",
                           con);
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                //reset all fields' values when save button is clicked
                txt_student_fname.Text = string.Empty;
                txt_student_mname.Text = string.Empty;
                txt_student_lname.Text = string.Empty;
                rad_student_male.Checked = false;
                rad_student_female.Checked = false;
                dateTimePicker.ResetText();
                txt_student_age.Text = string.Empty;
                txt_student_address.Text = string.Empty;
                chk_LB_hobbies_interests.Text = string.Empty;
                txt_student_health.Text = string.Empty;
                con.Close();
                MessageBox.Show("Student's details have been saved successfully!", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
            
      

        private void btn_student_upload_Click(object sender, EventArgs e)
        {
            
            {
                OpenFileDialog filedialog = new OpenFileDialog();
                filedialog.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    student_pic.Image = new Bitmap(filedialog.FileName);
                }
            }
        }

        private void btn_rp1_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                rp1_picture.Image = new Bitmap(filedialog.FileName);
            }
        }

        private void btn_rp2_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                rp2_picture.Image = new Bitmap(filedialog.FileName);
            }
        }

        /*private void rad_student_male_CheckedChanged(object sender, EventArgs e)
        {
            student_gender = "male";
        }*/

        /*private void rad_student_female_CheckedChanged(object sender, EventArgs e)
        {
            student_gender = "female";
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Burger_Infinity
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text.Equals(string.Empty) || usernameTxt.Text.Equals(string.Empty) || passwordTxt.Text.Equals(string.Empty) || passwordTxt.Text.Equals(string.Empty))
            {
                MessageBox.Show(" Field cannot be empty ");

            }


            else
            {


                if (passwordTxt.Text != ConfirmpassTxt.Text)
                {

                    MessageBox.Show("Password & Confirm Password Must Match");

                }
                else
                {
                    if (GenderCombo.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select Gender");
                    }
                    else if (dateTimePicker1.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please select a valid Date Of Birth");
                    }
                    else if (JcTxt.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a Category");
                    }
                    else if (JcTxt.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a blood group");
                    }

                    else if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("Please Select The Agreement");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");

                        con.Open();

                        string newcon = "insert into Registration(name,username,password,confirmpassword,email,catagory,gender,phonenumber,dateofbirth,bloodgroup) VALUES('" + nameTxt.Text + "','" + usernameTxt.Text + "','" + passwordTxt.Text + "','" + ConfirmpassTxt.Text + "','" + mailTxt.Text + "','" + JcTxt.Text + "','" + GenderCombo.Text + "','" + PhonenumberTxt.Text + "','" + dateTimePicker1.Text + "','" + comboBoxBlood.Text + "')";


                        SqlCommand cmd = new SqlCommand(newcon, con);

                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Registration Successful");



                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();

            this.Close();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
    


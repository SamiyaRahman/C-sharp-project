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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, " Please fill the field first!");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox2, " Please fill the field first!");
            }
            else
            {
                errorProvider2.Clear();

            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;

                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {

                SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");
                string query = "Select * from Registration where username=@user and  password = @pass";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Home h = new Home();
                    h.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Faild", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Please fill both filds first!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

       

        private void label6_Click_1(object sender, EventArgs e)
        {
            Registration_Form r = new Registration_Form();
            r.Show();

            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
            this.Hide();
        }

      

      

      
    }
}

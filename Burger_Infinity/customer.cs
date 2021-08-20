using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Burger_Infinity
{
    public partial class customer : Form
    {
        int count = 0;
        public customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();

            this.Hide();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            String total = label4.Text;
            MessageBox.Show(total, " Your-Bill");

            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");

            con.Open();

            string newcon = "insert into food_orders(Totalprice,Amount)VALUES('" + label1.Text + "','" + label4.Text + "')";
            SqlCommand cmd = new SqlCommand(newcon, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Place Successful");

            label4.Text = "00";
            label5.Text = "00";
        }

        private void btnBurger1_Click(object sender, EventArgs e)
        {
            count = count + 180;
            label4.Text = count.ToString();
            label5.Text = count.ToString();
        }

        private void btnBurger2_Click(object sender, EventArgs e)
        {
            count = count + 200;
            label4.Text = count.ToString();
            label5.Text = count.ToString();
        }

        private void btnBurger3_Click(object sender, EventArgs e)
        {
            count = count + 190;
            label4.Text = count.ToString();
            label5.Text = count.ToString();
        }

        private void btnBurger4_Click(object sender, EventArgs e)
        {
            count = count + 220;
            label4.Text = count.ToString();
            label5.Text = count.ToString();
        }

        private void btnBurger5_Click(object sender, EventArgs e)
        {
            count = count + 230;
            label4.Text = count.ToString();
            label5.Text = count.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = "00";
            label5.Text = "00";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

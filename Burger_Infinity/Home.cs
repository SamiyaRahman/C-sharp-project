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
    public partial class Home : Form
    {

        private string username = "";
        public Home()
        {
            InitializeComponent();
        }

       

 
       
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");
             string query = String.Format("select jobcatagory from Registration where username='{0}'", username);

             SqlCommand cmd = new SqlCommand(query, con);


             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             dr.Read();
            */

            /*SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");
            con.Open();
            string query = String.Format("select jobcatagory from Registration where username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader data = cmd.ExecuteReader();
            data.Read();*/

            Admin a = new Admin();
            a.Show();

            this.Close();
          /*  if (dr["catagory"].ToString() == "Manager")
            {
               
            }
            else { MessageBox.Show("You are not allowed to enter this section!"); }
          */
        }

     
       
        

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();

            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendor v = new Vendor();
            v.Show();

            this.Hide();
        }
    }
}

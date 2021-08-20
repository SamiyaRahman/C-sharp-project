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
using System.IO;

namespace Burger_Infinity
{
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            op.Filter = "All Image File (*.*) | *.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");
            string query = " insert into admin_table values (@id,@name,@age,@img) ";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);

            cmd.Parameters.AddWithValue("@img", SavePhoto());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Insert successful");
            }
            else
            {
                MessageBox.Show("Data not Insert");

            }
            con.Close();

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();


        }

         void BindGridView()
        {

            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Burger_Infinity;Integrated Security=True");


            string query = "select * from admin_table";
             SqlDataAdapter sda = new SqlDataAdapter(query, con);
             DataTable data = new DataTable();
             sda.Fill(data);
             dataGridView1.DataSource = data;

            DataGridViewImageColumn dv = new DataGridViewImageColumn();

            dv = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 50;

        }


    }
}

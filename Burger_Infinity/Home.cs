﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_Infinity
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       

 
       
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();

            this.Close();

        }
    }
}

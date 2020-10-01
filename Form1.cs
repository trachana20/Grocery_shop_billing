using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_shop_billing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String uname = textBox1.Text;
            String pass = textBox2.Text;
            if (uname.Equals("rachana") && pass.Equals("1234"))
            {
                var nextForm = new Form2();
                nextForm.Show();
            }
            else if(uname.Equals("monica") && pass.Equals("1234"))
            {
                var nextForm = new Form2();
                nextForm.Show();
            }
            else
            {
                label4.Show();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
    }
}

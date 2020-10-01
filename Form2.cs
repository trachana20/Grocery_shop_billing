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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
// radio buttons for vegetables
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tomato");
            comboBox1.Items.Add("Brinjal");
            comboBox1.Items.Add("CauliFlower");
            comboBox1.Items.Add("Carrot");
            comboBox1.Items.Add("Beetroot");
            comboBox1.Items.Add("Raddish");



        }
// radio buttons for fruits
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("apple");
            comboBox1.Items.Add("Banana");
            comboBox1.Items.Add("Mango");
            comboBox1.Items.Add("Grapes");
            comboBox1.Items.Add("Guava");
            comboBox1.Items.Add("Orange");
        }
// combination of item selected with its price
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Tomato") { txt_price.Text = "50"; }
            else if (comboBox1.SelectedItem.ToString() == "Brinjal") { txt_price.Text = "10"; }
            else if (comboBox1.SelectedItem.ToString() == "CauliFlower") { txt_price.Text = "60"; }
            else if (comboBox1.SelectedItem.ToString() == "Carrot") { txt_price.Text = "40"; }
            else if (comboBox1.SelectedItem.ToString() == "Beetroot") { txt_price.Text = "60"; }
            else if (comboBox1.SelectedItem.ToString() == "Raddish") { txt_price.Text = "30"; }
            else if (comboBox1.SelectedItem.ToString() == "apple") { txt_price.Text = "95"; }
            else if (comboBox1.SelectedItem.ToString() == "Banana") { txt_price.Text = "70"; }
            else if (comboBox1.SelectedItem.ToString() == "Grapes") { txt_price.Text = "90"; }
            else if (comboBox1.SelectedItem.ToString() == "Orange") { txt_price.Text = "60"; }
            else if (comboBox1.SelectedItem.ToString() == "Mango") { txt_price.Text = "85"; }
            else if (comboBox1.SelectedItem.ToString() == "Guava") { txt_price.Text = "70"; }
            else { txt_price.Text = "0"; }

            txt_total.Text = "";
            txt_qty.Text = "";
            

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = comboBox1.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;


            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

            
            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();



        }

        private void txt_disc_TextChanged(object sender, EventArgs e)
        {
            txt_net.Text= (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_disc.Text)).ToString();
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_bal.Text= (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

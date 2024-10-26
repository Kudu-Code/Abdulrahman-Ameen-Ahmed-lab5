using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        //Calculate Button
        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;bool f = false;
            text_result.Text = null;
            if(checkBox1.Checked) { s += Convert.ToInt32(checkBox1.Text);f = true; }
            if (checkBox2.Checked) { s += Convert.ToInt32(checkBox2.Text); f = true; }
            if (checkBox3.Checked) { s += Convert.ToInt32(checkBox3.Text); f = true; }
            if (checkBox4.Checked) { s += Convert.ToInt32(checkBox4.Text); f = true; }
            if (checkBox5.Checked) { s += Convert.ToInt32(checkBox5.Text); f = true; }
            if (f)
                text_result.Text = s.ToString();

        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (radioButton_red.Checked)
                label1.BackColor = Color.Red;
            else if (radioButton_yellow.Checked)
                label1.BackColor = Color.Yellow;
            else if (radioButton_green.Checked)
                label1.BackColor = Color.Green;
            else if (radioButton_black.Checked)
                label1.BackColor = Color.Black;
            //*******************************
             if (radioButton1.Checked)
                label1.ForeColor = Color.Red;
            else if (radioButton2.Checked)
                label1.ForeColor = Color.Yellow;
            else if (radioButton3.Checked)
                label1.ForeColor = Color.Green;
            else if (radioButton4.Checked)
                label1.ForeColor = Color.Black;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_visible_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button_unvisible_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

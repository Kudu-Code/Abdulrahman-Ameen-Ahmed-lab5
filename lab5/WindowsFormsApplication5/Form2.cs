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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = this.Width + 100;
            this.Height = this.Height + 100;
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            buttonplayer.Top -= 5;
        }

        private void button_plus_up_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width, buttonplayer.Height + 5);
        }

        private void button_plus_right_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width+5, buttonplayer.Height);
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            buttonplayer.Location = new Point(buttonplayer.Left + 5, buttonplayer.Top);
        }

        private void button_minus_down_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width, buttonplayer.Height - 5);
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            buttonplayer.Top += 5;
        }

        private void button_minus_left_Click(object sender, EventArgs e)
        {
            buttonplayer.Size = new Size(buttonplayer.Width-5, buttonplayer.Height);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            buttonplayer.Location = new Point(buttonplayer.Left - 5, buttonplayer.Top);
        }

        private void buttonplayer_Click(object sender, EventArgs e)
        {

        }
    }
}

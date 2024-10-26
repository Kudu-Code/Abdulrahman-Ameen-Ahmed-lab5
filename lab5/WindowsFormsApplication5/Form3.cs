using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = this.Width + 100;
            this.Height = this.Height + 100;
        }
        void go()
        {
            for (int i = 0; i <= this.Width; i++)
            {
                Invoke((Action)(() => { button1.Left += 10; }));
                if (button1.Left > this.Width - button1.Width - 50)
                {
                    break;
                }
                Thread.Sleep(100);
            }
        }

        private void button_forward_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < this.Width - button1.Width; i++)
            //    button1.Left += 1;
            threadgo = new Thread(go);
            threadgo.Start();
        }
        Thread threadgo;
        private void button_downward_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < this.Height - button2.Height; i++)
            //    button2.Top += 1;
            int j = button2.Top;
           for(int i = button2.Top; i <= this.Height - button2.Height; i++)
            {
                if (button2.Top > this.Height - button2.Height - 70)
                {
                    break;
                }
                button2.Top += 10;
                Thread.Sleep(100);
                Application.DoEvents();
            }
            button2.Top = j;
        }
        private void form_closing(object sender,EventArgs e)
        {
            if (threadgo != null)
                threadgo.Abort();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            form_closing(null, null);
        }
    }
}

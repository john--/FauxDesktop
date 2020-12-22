using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FauxDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Visible = false;
            this.label1.Visible = false;
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.listBox1.Visible = false;
            this.label2.Visible = false;
            /*
                     this.ControlBox = false;
            this.Text = String.Empty;
            */
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] res = this.listBox1.SelectedItem.ToString().Split('x');
            this.Width = Convert.ToInt32(res[0]);
            this.Height = Convert.ToInt32(res[1]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

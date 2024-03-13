using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osvezeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bigButt_Click(object sender, EventArgs e)
        {
            bigButt.Text = "It was a man";
            bigButt.Enabled = false;
            label1.Text = textBox1.Text;
            if (radioButton1.Checked ) 
            {
                label1.Text = "eo";
            }
        }
    }
}

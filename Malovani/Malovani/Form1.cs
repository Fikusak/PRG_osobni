using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Malovani
{
    public partial class Form1 : Form
    {
        Pen p;
        Graphics g;
        bool paint = false;
        Point px, py;
        int index;
        Pen er;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            panel1.BackColor = Color.White;
            g = panel1.CreateGraphics();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = float.Parse(comboBox1.Text);
            p = new Pen(Color.Black, size);
            er = new Pen(Color.White, size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, this.button1.Text);     
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, this.button2.Text);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button4, this.button4.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                else if(index==0)
                {
                    px = e.Location;
                    g.DrawLine(er, px, py);
                    py = px;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Color = colorDialog1.Color;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        
    }
    
}

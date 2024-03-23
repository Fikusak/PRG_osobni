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
        SolidBrush b;
        Graphics g;
        bool paint = false;
        float size;
        Point px, py;
        int index = 1;
        Pen er;
        int x, y, fX, fY, lX, lY;
        int fill;
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            panel1.BackColor = Color.White;
            g = panel1.CreateGraphics();
            comboBox1.Text = "1";
            textBox1.BackColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = float.Parse(comboBox1.Text);
            p = new Pen(colorDialog1.Color, size);
            er = new Pen(Color.White, 15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 0;
        }
        
        private void button2_Click(object sender, EventArgs e)
        { 
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            p = new Pen(colorDialog1.Color, size);
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

        private void button6_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, this.button2.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fill = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fill = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png";
                
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                panel1.BackgroundImage = Image.FromFile(imageLocation);
                panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            fX = e.X;
            fY = e.Y;
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
                if(index==0)
                {
                    px = e.Location;
                    g.DrawLine(er, px, py);
                    py = px;
                }
            }

            x = e.X;
            y = e.Y;
            lX = e.X - fX;
            lY = e.Y - fY;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            b = new SolidBrush(colorDialog1.Color);
            lX = x - fX;
            lY = y - fY;

            if (index == 2 && fill == 0)
            {
                g.DrawEllipse(p, fX, fY, lX, lY);
            }
            else if (index == 2 && fill == 1)
            {
                g.FillEllipse(b, fX, fY, lX, lY);
            }
            if (index == 3 && fill == 0)
            {
                g.DrawRectangle(p, fX, fY, lX, lY);
            }
            else if (index == 3 && fill == 1)
            {
                g.FillRectangle(b, fX, fY, lX, lY);
            }
            if (index == 4)
            {
                g.DrawLine(p, fX, fY, x, y);
            }
        }
    }
    
}

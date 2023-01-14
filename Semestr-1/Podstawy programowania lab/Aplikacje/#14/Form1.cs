using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pierwsza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // rysowanie figur
            
            
        
        
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = splitContainer1.Panel1.CreateGraphics();

            Pen pioro = new System.Drawing.Pen(System.Drawing.Color.Green);
            graphics.DrawEllipse(pioro, new System.Drawing.Rectangle(100, 0, 300, 300));
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            splitContainer1.Panel2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "tekst";
        }
    }
}
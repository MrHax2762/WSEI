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

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = tabPage1.CreateGraphics();
            Pen pioro = new System.Drawing.Pen(System.Drawing.Color.Green);
            graphics.DrawEllipse(pioro, new System.Drawing.Rectangle(100, 0, 300, 300));
      
        }
    }
}
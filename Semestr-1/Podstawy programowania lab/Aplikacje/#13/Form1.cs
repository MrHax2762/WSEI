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

        private void timer1_Tick(object sender, EventArgs e)
        {
            numericUpDown1.Value++;
            //button1.Location = new System.Drawing.Point(button1.Location.X + 1, button1.Location.Y);
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(button1.Location.X+1, button1.Location.Y);
        }

       
    }
}
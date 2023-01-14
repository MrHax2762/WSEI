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
            
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle rectangle1 = new System.Drawing.Rectangle(100, 100, 200, 200);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle1);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle1);

            // definiowanie piór

            Pen pioro = new System.Drawing.Pen(System.Drawing.Color.Green);
            pioro.Color = System.Drawing.Color.PeachPuff;
            graphics.DrawEllipse(pioro, new System.Drawing.Rectangle(100, 0, 200, 200));
            
            // definiowanie brush

            System.Drawing.SolidBrush pedzel;
            pedzel = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            graphics.FillEllipse(pedzel, new System.Drawing.Rectangle(0, 100, 200, 200));
 
            pioro.Dispose();
            pedzel.Dispose();

            // rysowanie linii

            System.Drawing.Pen pioro2;
            pioro2 = new System.Drawing.Pen(System.Drawing.Color.Purple);
            graphics.DrawLine(pioro2, 300, 200, 500, 300);
            pioro2.Dispose();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image graf = System.Drawing.Image.FromFile(@"c:\aa.bmp");
            this.CreateGraphics().DrawImage(graf, new Point(350, 100));
            graf.Save(@"c:\aa.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox nowy = sender as TextBox;
            button1.Text = nowy.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
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

            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string tekst = "Tekst przyk³adowy";
            System.Drawing.Font czcionka = new System.Drawing.Font("Arial", 129);
            System.Drawing.SolidBrush pedzel1 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(50, 10, 10, 10)); //ierwszy param FromArgb to appha
            System.Drawing.SolidBrush pedzel2 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(50, 255, 10, 10)); //ierwszy param FromArgb to appha
            float x = 150.0f;
            float y = 50.0f;
            System.Drawing.StringFormat format  = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
            formGraphics.DrawString(tekst, czcionka, pedzel1, x, y, format);
            format.FormatFlags = StringFormatFlags.DisplayFormatControl;
            formGraphics.DrawString(tekst, czcionka, pedzel2, x, y, format);
            czcionka.Dispose();
            pedzel1.Dispose();
            pedzel2.Dispose();

            formGraphics.Dispose();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Blue;

        }
    }
}
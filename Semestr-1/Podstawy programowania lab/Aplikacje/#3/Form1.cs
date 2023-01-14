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
        int kolor = 0;
        public Form1()
        {
            
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // rysowanie figur
                  
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            System.Drawing.Drawing2D.GraphicsPath ksztalt =
            new System.Drawing.Drawing2D.GraphicsPath();
            ksztalt.FillMode = System.Drawing.Drawing2D.FillMode.Winding;
            ksztalt.AddEllipse(0, 0, this.Width*2, this.Height);
            ksztalt.AddEllipse(0, 0,200,200);
            this.Region = new System.Drawing.Region(ksztalt);
    
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            kolor = (kolor < 5) ? ++kolor : 0;
            switch (kolor) {
                case 0: this.BackColor = System.Drawing.Color.DarkBlue; break;
                case 1: this.BackColor = System.Drawing.Color.Yellow; break;
                case 2: this.BackColor = System.Drawing.Color.Tomato; break;
                case 3: this.BackColor = System.Drawing.Color.Wheat; break;
                case 4: this.BackColor = System.Drawing.Color.Gold; break;
            }
        }
    }
}
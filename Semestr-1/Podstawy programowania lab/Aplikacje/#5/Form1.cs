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

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox formatka = new System.Windows.Forms.TextBox();
            formatka.Location = new System.Drawing.Point(10,20);
            formatka.Name = "formatka";
            formatka.Size = new System.Drawing.Size(100,20);
            formatka.TabIndex = 0;
            formatka.Text = "formatka";
                // dodanie formaki
            Controls.Add(formatka);
                // dodanie zdarzenia
            formatka.Click += new EventHandler(kliknieto);
        }
        private void kliknieto(object sender, System.EventArgs e)
        {
            MessageBox.Show("zdarzenie.");
        }
    }
}
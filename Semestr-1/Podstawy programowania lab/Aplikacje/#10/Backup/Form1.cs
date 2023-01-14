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

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.richTextBox1, "Opis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.pl");
        }

        private void webBrowser1_Navigating(object sender
            , WebBrowserNavigatingEventArgs e)
        {
            
            MessageBox.Show("Nawigacja: " + e.Url);
            
        }
    }
}
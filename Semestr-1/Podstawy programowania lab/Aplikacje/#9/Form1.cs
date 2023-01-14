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
            if (progressBar1.Value + progressBar1.Step > progressBar1.Maximum) progressBar1.Value = progressBar1.Minimum;
            progressBar1.Value += progressBar1.Step;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 10;
            progressBar1.Value = 30;
            progressBar1.Step = 10;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) MessageBox.Show ("Wybrano " + radioButton1.Text);
            if (radioButton2.Checked) MessageBox.Show ("Wybrano " + radioButton2.Text);
            if (radioButton3.Checked) MessageBox.Show ("Wybrano " + radioButton3.Text);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
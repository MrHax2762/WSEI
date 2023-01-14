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

        }

        private void wybor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akcja");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akcja");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "zmieniony";
            // lub:  statusLabel1.Text = "zmieniony";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void opcja2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akcja");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            modyfikowalnaToolStripMenuItem.Enabled = checkBox1.Checked;
        }

        private void modyfikowalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akcja");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void wybor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opcja1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 
  
    }
}
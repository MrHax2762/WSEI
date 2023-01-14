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

            Przycisk1 przycisk = new Przycisk1();
            EventHandler handler = new EventHandler(przycisk_Click);
            // dodanie obs³ugi zdarzenia Click
            przycisk.Click += handler;
            przycisk.Location = new System.Drawing.Point(290, 180);
            przycisk.Size = new System.Drawing.Size(51, 51);
            this.Controls.Add(przycisk);

        }

        // klasa zagniezdzona przycisku
        public class Przycisk1 : UserControl
        {
            // rysowanie przysisku 
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Pen pen = new Pen(Color.Black);
              
                graphics.DrawEllipse(pen, 0, 0, 50, 50);
                pen.Dispose();
            }
        }
        
        // obs³uga zdarzenia przycisku
        public void przycisk_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }

            
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode!= null)
                MessageBox.Show(treeView1.SelectedNode.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
                TreeNode node = treeView1.SelectedNode;
                if (node != null)
                    node.Nodes.Add(textBox1.Text);
                else
                    treeView1.Nodes.Add(textBox1.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
               // wymuszenie klikniêcia
            button4.PerformClick();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naciœniêto przycisk");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
                treeView1.Nodes.Remove(node);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
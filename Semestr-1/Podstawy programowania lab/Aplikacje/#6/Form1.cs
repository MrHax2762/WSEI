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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // pobranie stanu CheckBox
            MessageBox.Show("Stan checbox: " + checkBox1.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pobranie zaznaczenia CheckListBox
            if (checkedListBox1.SelectedIndex >= 0)
                MessageBox.Show(checkedListBox1.SelectedItems[0].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dodanie do CheckListBox
            checkedListBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // pobranie zaznaczenia ComboBox
            if (comboBox1.SelectedIndex >= 0)
                MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // dodanie do ComboBox
            comboBox1.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           if  (comboBox1.SelectedItem != null)
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                
        }

        
    }
}
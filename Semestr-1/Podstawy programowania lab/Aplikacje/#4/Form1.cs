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

        private void button2_Click(object sender, EventArgs e)
        {
            Okienko okno = new Okienko();
            okno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.LoadFile(openFile1.FileName,
                RichTextBoxStreamType.PlainText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.SaveFile(saveFile1.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Komunikat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Komunikat", "Tytul", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)){
                case DialogResult.Yes:
                    MessageBox.Show("wybrano Yes");
                    break;
                case DialogResult.No:
                    MessageBox.Show("wybrano No");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("wybrano Cancel");
                    break;

            }
        }
    }
}
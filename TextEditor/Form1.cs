using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void форматирайToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select your file";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "All Files (.)|*.*Text Files(.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader st = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = st.ReadToEnd();
                st.Close();
            }
        }

        private void запазиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = " Save your file";
            saveFileDialog1.Filter = "Text Files(.txt)|*.txt|Batch File|*.bat|Rich text file|*.rtf|Word Document|*.docx";
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
                
        }

        private void запазиКатоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = " Save your file";
            saveFileDialog1.Filter = "All Files (.)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}

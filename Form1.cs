using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private object fontDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File (.txt)|*.txt";
            ofd.Title= "Open file";

            if (ofd.ShowDialog() == DialogResult.OK) 
            { 
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text= sr.ReadToEnd();
                sr.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File (.txt)|*.txt";
            sfd.Title = "Save File";

            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            DialogResult fd = fontDialog1.ShowDialog();
            if (fd == DialogResult.OK)
            {
                richTextBox1.Font= fontDialog1.Font;
            }
        }

        private void fontColor_Click(object sender, EventArgs e)
        {
            DialogResult cd = colorDialog1.ShowDialog();

            if (cd == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

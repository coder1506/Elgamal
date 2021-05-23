using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DaoDinhDuc_btl_elgamal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                string filePath = openFileDialog1.FileName;
                pathFile.Text = filePath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog2.FileName);
                string filePath = openFileDialog2.FileName;
                fileCheck.Text = filePath;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblWindowsFormsApp1.Text = "Hello word";
            label1.Text = "Hello abc ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string show = "Hello " + textBox1.Text;
            button1.Text = show;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

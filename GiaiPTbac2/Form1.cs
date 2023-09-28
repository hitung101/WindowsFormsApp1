using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            double x1, x2;

            double delta = b * b - 4 * a * c;

            // Kiểm tra giá trị của delta
            if (delta > 0)
            {
                // Hai nghiệm phân biệt
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                textBox4.Text = $" x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                // Một nghiệm kép
                double x = -b / (2 * a);
                textBox4.Text = $"kép: x = {x}";
            }
            else
            {
                // Không có nghiệm thực
                textBox4.Text = "Phương trình không có nghiệm thực.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

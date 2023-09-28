using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCaculator
{
    public partial class GPTB2 : Form
    {
        public Form1 objform1;

        public GPTB2()
        {
            InitializeComponent();
        }
        public GPTB2(Form1  frm)
        {

            InitializeComponent();
            objform1 = frm;
        }
        private void button21_Click(object sender, EventArgs e)
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
                hienthi1.Text = $" x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                // Một nghiệm kép
                double x = -b / (2 * a);
                hienthi1.Text = $"kép: x = {x}";
            }
            else
            {
                // Không có nghiệm thực
                hienthi1.Text = "Phương trình vô nghiệm.";
            }
        }

        private void GPTB2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
         
       
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }
    }
}

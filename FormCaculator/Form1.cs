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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float data1, data2;
        string pheptinh;
        private void hienthi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hienthi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " + " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();

            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " - " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " x " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if(float.Parse(hienthi1.Text) == 0){
                    hienthi1.Text = " Không chia được ";
                }
                else
                {
                    data2 = data1 / float.Parse(hienthi1.Text);
                    hienthi2.Text = data1.ToString() + " / " + float.Parse(hienthi1.Text) + " = ";
                    hienthi1.Text = data2.ToString();
                }
                  
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " - ";
            hienthi1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " x ";
            hienthi1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " / ";
            hienthi1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GPTB2 fmmhgptb2 = new GPTB2(this);
            fmmhgptb2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAppIntroduction.Forms;

namespace WFAppIntroduction
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome Trainer!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.ToLower().Equals("admin") && textBox5.Text.ToLower().Equals("admin"))
            {
                WFIngresos form = new WFIngresos();
                form.Show();
            }
            else
            {
                textBox4.Clear();
                textBox5.Clear();
                if (count >= 3)
                {
                    MessageBox.Show("Banned :v");
                    button1.Enabled = false;
                }
                else
                {
                    count++;
                    MessageBox.Show("No access :v");
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

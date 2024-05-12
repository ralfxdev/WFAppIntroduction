using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppIntroduction.Forms
{
    public partial class WFIngresos : Form
    {
        public WFIngresos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Int32.Parse(textBox1.Text);
            int valor2 = Int32.Parse(textBox2.Text);

            int resultado = valor1 + valor2;

            textBox3.Text = resultado.ToString();

            comboBox1.Items.Add("Ingenieria");
            comboBox1.Items.Add("Medicina");
            comboBox1.Items.Add("Derecho");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}

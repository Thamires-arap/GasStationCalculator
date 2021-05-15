using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1._4
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

        private void button1_Click(object sender, EventArgs e)
        {
            double valorGasolina, quantidadeDeLitros, total;

            valorGasolina = Convert.ToDouble(label3.Text);
            quantidadeDeLitros = Convert.ToDouble(textBox1.Text);

            total = valorGasolina * quantidadeDeLitros;

            MessageBox.Show("R$ " + Convert.ToString(total), "Valor a pagar");
        }
    }
}

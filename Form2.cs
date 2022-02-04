using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3E
{
    public partial class Form2 : Form
    {
        Cuenta cuenta = new Cuenta();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuenta.NoCuenta = textBoxNumCuenta.Text;
            cuenta.DPI = textBox2DPICliente.Text;
            cuenta.Saldo = Convert.ToDouble(textBoxSaldo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumCuenta.Text = cuenta.NoCuenta;
            labelDPICliente.Text = cuenta.DPI;
            labelSaldo.Text = "Q. " + cuenta.Saldo.ToString();
        }
    }
}

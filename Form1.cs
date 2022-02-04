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
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        /*Persona persona1 = new Persona();
        Persona persona2 = new Persona();*/

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //int a = 5;

            //clase objeto

            persona.DPI = textBoxDPI.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.normalizarNombre();
            persona.FechaNacimiento = dateTimePickerNacimiento.Value;
            persona.edad();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            persona.normalizarNombre();
            labelDPI.Text = persona.DPI;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelNacimiento.Text = persona.FechaNacimiento.ToString();
            labelEdad.Text = persona.edad().ToString() + " años";
        }

        private void buttonCuentas_Click(object sender, EventArgs e)
        {
            Form2 formcuenta = new Form2();

            formcuenta.Show();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 127)
                || (e.KeyChar >= 145 && e.KeyChar <= 146) || (e.KeyChar >= 155 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180)
                || (e.KeyChar >= 184 && e.KeyChar <= 197) || (e.KeyChar >= 200 && e.KeyChar <= 208) || (e.KeyChar >= 217 && e.KeyChar <= 223)
                || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente Letras!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 127)
                || (e.KeyChar >= 145 && e.KeyChar <= 146) || (e.KeyChar >= 155 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180)
                || (e.KeyChar >= 184 && e.KeyChar <= 197) || (e.KeyChar >= 200 && e.KeyChar <= 208) || (e.KeyChar >= 217 && e.KeyChar <= 223)
                || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente Letras!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente Números!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            //textBoxNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxNombre.Text);
            //textBoxNombre.SelectionStart = textBoxNombre.Text.Length;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            //textBoxApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxApellido.Text);
            //textBoxApellido.SelectionStart = textBoxApellido.Text.Length;
        }
    }
}

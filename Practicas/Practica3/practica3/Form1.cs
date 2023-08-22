using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validarButton_Click(object sender, EventArgs e)
        {

            string numero = campo1TextBox.Text;
            string letra = campo2TextBox.Text;

            if (string.IsNullOrEmpty(letra) || string.IsNullOrWhiteSpace(letra) ) {
                MessageBox.Show("Escribe un texto");
            }

            if (int.TryParse(numero, out int n))
            {
                MessageBox.Show("Es un numero");
            }
            else
            {
                MessageBox.Show("No es un numero");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_la_potencia.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(NumeroText.Text);
            double exponente = double.Parse(ExponenteText.Text);

            double resultado = Math.Pow(numero, exponente);

            MessageBox.Show("La potencia es: " + resultado);
        }
    }
}

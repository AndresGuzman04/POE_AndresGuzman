using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interesCompuestoUI.Forms
{
    public partial class interesCompuesto : Form
    {
        public interesCompuesto()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            double montoInicial = double.Parse(montoInicialTextBox.Text);
            double porcentaje = double.Parse(porcentajeTextBox.Text);
            double interesCompuesto;

            interesCompuesto = montoInicial + (montoInicial * (porcentaje / 100));

            resultadoLabel.Text = "=" + interesCompuesto.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1UI.Forms
{
    public partial class InteresSimpleForm : Form
    {
        public InteresSimpleForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            double capitalInicial = double.Parse(capitalIncialTextBox.Text);
            double tasaInteres = double.Parse(tasaInteresTexBox.Text);
            double periodoTiempo = double.Parse(periodoTiempoTextBox.Text);
            double capitalFinalResultante;

            capitalFinalResultante = capitalInicial * (1 + (tasaInteres * periodoTiempo));

            resultadoLabel.Text = "$"+capitalFinalResultante.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1.Forms
{
    public partial class Form2 : Form
    {

        Calculadora objeto1 = new Calculadora(5, 6);

        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lanzarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objeto1.Suma().ToString());
            MessageBox.Show(objeto1.Resta().ToString());
            MessageBox.Show(objeto1.Mulriplicacion().ToString());
            MessageBox.Show(objeto1.Division().ToString());
        }
    }
}

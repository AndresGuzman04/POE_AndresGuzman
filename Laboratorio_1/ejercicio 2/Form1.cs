using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterbutton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Se presionó la tecla Enter");
            }
             if (char.IsLetter(e.KeyChar))
            //IsLetter Este método determina si un Char es miembro de cualquier categoría de letra Unicode
            {
                MessageBox.Show($"Se presionó la letra: {e.KeyChar}");
                }
            }

        private void enterbutton_Click(object sender, EventArgs e)
        {

        }

        private void respuesta_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDividir(object sender, EventArgs e)
        {
            try
            {
                int numero1;
                int numero2;
                int resultado;
                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text); 
                resultado = numero1/ numero2;
                textBox3.Text = resultado.ToString();

          
            }
            catch(DivideByZeroException e1) { 
           //segun lo que entendi el zero exception es que no se puede dividir entre cero
                MessageBox.Show("Divide by zero exception no podemos dividir un numero a cero", e1.Message);
            }
        }
    }
}

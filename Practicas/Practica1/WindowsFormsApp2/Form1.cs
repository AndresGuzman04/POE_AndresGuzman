using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //evaluar si no es una tecla de control o un caracter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //nos permite no permitir el acceso de esas teclas
                e.Handled = true;
                label1.Text = "Solo se permiten numeros";

            }
            else
            {
                label1.Text = "";
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres");
            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            string email = textBox3.Text; // Se crea variable para almacenar email dek textbox
            bool isOk = emailValido(email);// se llama el metodo y se le pasa el parametro
            if (isOk == false) //  Verificar  si es false o true para imprimir el resultado
            {
                MessageBox.Show("Correo  Invalido");
            }
            else {
                MessageBox.Show($"Correo {email} Valido");  
            }
        }

        static bool emailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);// Se crea variable para alamacensar el email a partir del metodo
                                                                  // y pasando parametro al mismo
                return addr.Address == email; //Se retorna true si es valido
            }
            catch
            {
                return false;// retorno false
            }
        }
    }
}

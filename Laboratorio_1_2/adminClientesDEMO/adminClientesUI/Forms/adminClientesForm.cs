using EventLibrary;
using EventLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adminClientesUI.Forms
{
    public partial class adminClientesForm : Form
    {
        public adminClientesForm()
        {
            InitializeComponent();

            InitializeEstadoComboBox();
        }

        private void InitializeEstadoComboBox()
        {
            estadoComboBox.Items.AddRange(Enum.GetNames(typeof(EstadoClienteEnum)));
            estadoComboBox.SelectedIndex = 0;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();


            var emailNotification = new EventLibrary.EmailNotification();
            emailNotification.EmailBienvenidaNotificacionEvent += EmailNotification_EmailBienvenidaNotificacionEvent;





            cliente.nombre = nombreTextBox.Text;
            cliente.edad = edadTextBox.Text;
            cliente.email = emailTexBox.Text;
            cliente.estado = (EstadoClienteEnum)estadoComboBox.SelectedIndex;

            bool isOk = emailValido(cliente.email);


            if (string.IsNullOrEmpty(cliente.nombre) || string.IsNullOrWhiteSpace(cliente.nombre))
            {

                errorProvider1.SetError(nombreTextBox, "Escribe un texto");
            }
            else if (isOk == false)
            {
                errorProvider1.SetError(nombreTextBox, "");
                errorProvider1.SetError(emailTexBox, "Correo  Invalido");
            }
            else if (int.TryParse(cliente.edad, out int n))
            {
                string clienteInfo = string.Format("{0}, {1}, {2}, {3}", cliente.nombre, cliente.edad, cliente.email, cliente.estado);
                clientesListBox.Items.Add(clienteInfo);

                errorProvider1.SetError(emailTexBox, "");
                emailNotification.EmailBienvenidaNotificacion(cliente.email);
                errorProvider1.SetError(edadTextBox, "");

            }
            else
            {
                errorProvider1.SetError(edadTextBox, "No es un numero");
            }


        }

        private void EmailNotification_EmailBienvenidaNotificacionEvent(object? sender, EmailNotificationEventArgs e)
        {
            MessageBox.Show($"Evento de bienvenida: {e.Message}");
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
                return false;
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            clientesListBox.Items.Remove(clientesListBox.SelectedItem);
        }
    }
}

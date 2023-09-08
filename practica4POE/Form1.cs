using static tiempos.tiempos;

namespace practica4poe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataCombobox();
        }
        public void InitializeDataCombobox()
        {
            foreach (int i in Enum.GetValues(typeof(Horas)))
            {
                iniciocomboBox.Items.Add(i);
            }

            foreach (int i in Enum.GetValues(typeof(Horas)))
            {
                fincomboBox.Items.Add(i);
            }

            ampmcomboBox.Items.AddRange(Enum.GetNames(typeof(Horario)));
            iniciocomboBox.SelectedIndex = 0;
            fincomboBox.SelectedIndex = 0;
            ampmcomboBox.SelectedIndex = 0;


        }




        private void guardarbutton_Click(object sender, EventArgs e)
        {
            string materia, inicio, fin, horario, mensaje;

            materia = materiatextBox.Text;
            inicio = iniciocomboBox.SelectedItem.ToString();
            fin = fincomboBox.SelectedItem.ToString();
            horario = ampmcomboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(materia) || string.IsNullOrWhiteSpace(materia))
            {
                MessageBox.Show("escribe una materia");
                return;

            }
            mensaje = $"Materia: {materia}, Hora de inicio: {inicio}, hora de fin: {fin}, Horario: {horario}";
            materiaslistBox.Items.Add(mensaje);
            materiatextBox.Clear();

        }
    }
}
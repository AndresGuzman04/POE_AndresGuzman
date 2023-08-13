using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicaOperacion.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MultiplicarButton_MouseClick(object sender, MouseEventArgs e)
        {
            int firstNumber = int.Parse(firstNumberText.Text);
            int secondNumber = int.Parse(secondNumberText.Text);

            int result = firstNumber * secondNumber;

            resultLabel.Text = $"El resultado es: {result}";
        }
    }
}

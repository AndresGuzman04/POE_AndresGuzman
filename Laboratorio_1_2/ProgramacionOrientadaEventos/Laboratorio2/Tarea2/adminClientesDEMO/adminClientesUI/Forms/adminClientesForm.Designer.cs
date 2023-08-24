namespace adminClientesUI.Forms
{
    partial class adminClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clientesListBox = new ListBox();
            label1 = new Label();
            addClienteGroupBox = new GroupBox();
            estadoComboBox = new ComboBox();
            estadoLabel = new Label();
            agregarButton = new Button();
            emailTexBox = new TextBox();
            label3 = new Label();
            edadTextBox = new TextBox();
            label2 = new Label();
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            adminClienteGroupBox = new GroupBox();
            editarButton = new Button();
            eliminarButton = new Button();
            panel3 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            addClienteGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            adminClienteGroupBox.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // clientesListBox
            // 
            clientesListBox.Dock = DockStyle.Fill;
            clientesListBox.FormattingEnabled = true;
            clientesListBox.ItemHeight = 28;
            clientesListBox.Items.AddRange(new object[] { "Ejemplo1", "Ejemplo2" });
            clientesListBox.Location = new Point(0, 0);
            clientesListBox.Margin = new Padding(4);
            clientesListBox.Name = "clientesListBox";
            clientesListBox.SelectionMode = SelectionMode.MultiExtended;
            clientesListBox.Size = new Size(440, 440);
            clientesListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(882, 63);
            label1.TabIndex = 1;
            label1.Text = "Administrador de Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addClienteGroupBox
            // 
            addClienteGroupBox.BackgroundImageLayout = ImageLayout.Center;
            addClienteGroupBox.Controls.Add(estadoComboBox);
            addClienteGroupBox.Controls.Add(estadoLabel);
            addClienteGroupBox.Controls.Add(agregarButton);
            addClienteGroupBox.Controls.Add(emailTexBox);
            addClienteGroupBox.Controls.Add(label3);
            addClienteGroupBox.Controls.Add(edadTextBox);
            addClienteGroupBox.Controls.Add(label2);
            addClienteGroupBox.Controls.Add(nombreTextBox);
            addClienteGroupBox.Controls.Add(nombreLabel);
            addClienteGroupBox.Dock = DockStyle.Top;
            addClienteGroupBox.ForeColor = Color.White;
            addClienteGroupBox.Location = new Point(0, 0);
            addClienteGroupBox.Name = "addClienteGroupBox";
            addClienteGroupBox.Size = new Size(440, 299);
            addClienteGroupBox.TabIndex = 2;
            addClienteGroupBox.TabStop = false;
            addClienteGroupBox.Text = "Agregar Cliente";
            // 
            // estadoComboBox
            // 
            estadoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoComboBox.FormattingEnabled = true;
            estadoComboBox.Location = new Point(243, 157);
            estadoComboBox.Name = "estadoComboBox";
            estadoComboBox.Size = new Size(167, 36);
            estadoComboBox.TabIndex = 4;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(243, 126);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(80, 28);
            estadoLabel.TabIndex = 7;
            estadoLabel.Text = "Estado:";
            // 
            // agregarButton
            // 
            agregarButton.BackColor = Color.DodgerBlue;
            agregarButton.ForeColor = Color.White;
            agregarButton.Location = new Point(243, 216);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(167, 65);
            agregarButton.TabIndex = 5;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = false;
            agregarButton.Click += agregarButton_Click;
            // 
            // emailTexBox
            // 
            emailTexBox.Location = new Point(243, 74);
            emailTexBox.Name = "emailTexBox";
            emailTexBox.Size = new Size(167, 34);
            emailTexBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 43);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // edadTextBox
            // 
            edadTextBox.Location = new Point(23, 157);
            edadTextBox.Name = "edadTextBox";
            edadTextBox.Size = new Size(167, 34);
            edadTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 126);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 2;
            label2.Text = "Edad:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(23, 74);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(167, 34);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(23, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(94, 28);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 63);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(adminClienteGroupBox);
            panel2.Controls.Add(addClienteGroupBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 440);
            panel2.TabIndex = 4;
            // 
            // adminClienteGroupBox
            // 
            adminClienteGroupBox.Controls.Add(editarButton);
            adminClienteGroupBox.Controls.Add(eliminarButton);
            adminClienteGroupBox.Dock = DockStyle.Bottom;
            adminClienteGroupBox.ForeColor = Color.White;
            adminClienteGroupBox.Location = new Point(0, 305);
            adminClienteGroupBox.Name = "adminClienteGroupBox";
            adminClienteGroupBox.Size = new Size(440, 135);
            adminClienteGroupBox.TabIndex = 3;
            adminClienteGroupBox.TabStop = false;
            adminClienteGroupBox.Text = "Admin Cliente";
            // 
            // editarButton
            // 
            editarButton.BackColor = Color.DodgerBlue;
            editarButton.ForeColor = Color.White;
            editarButton.Location = new Point(23, 45);
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(167, 65);
            editarButton.TabIndex = 6;
            editarButton.Text = "Editar";
            editarButton.UseVisualStyleBackColor = false;
            editarButton.Click += editarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.BackColor = Color.DodgerBlue;
            eliminarButton.ForeColor = Color.White;
            eliminarButton.Location = new Point(243, 45);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(167, 65);
            eliminarButton.TabIndex = 7;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = false;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(clientesListBox);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(442, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 440);
            panel3.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // adminClientesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(882, 503);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Transparent;
            Margin = new Padding(4);
            Name = "adminClientesForm";
            Text = "adminClientesForm";
            addClienteGroupBox.ResumeLayout(false);
            addClienteGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            adminClienteGroupBox.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox clientesListBox;
        private Label label1;
        private GroupBox addClienteGroupBox;
        private Button agregarButton;
        private TextBox emailTexBox;
        private Label label3;
        private TextBox edadTextBox;
        private Label label2;
        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Panel panel1;
        private Panel panel2;
        private GroupBox adminClienteGroupBox;
        private Button editarButton;
        private Button eliminarButton;
        private Panel panel3;
        private ComboBox estadoComboBox;
        private Label estadoLabel;
        private ErrorProvider errorProvider1;
    }
}
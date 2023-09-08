namespace practica4poe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iniciocomboBox = new ComboBox();
            fincomboBox = new ComboBox();
            titulolabel = new Label();
            iniciolabel = new Label();
            finlabel = new Label();
            guardarbutton = new Button();
            ampmlabel = new Label();
            ampmcomboBox = new ComboBox();
            materiatextBox = new TextBox();
            materiaslistBox = new ListBox();
            SuspendLayout();
            // 
            // iniciocomboBox
            // 
            iniciocomboBox.FormattingEnabled = true;
            iniciocomboBox.Location = new Point(375, 75);
            iniciocomboBox.Name = "iniciocomboBox";
            iniciocomboBox.Size = new Size(207, 28);
            iniciocomboBox.TabIndex = 0;
            // 
            // fincomboBox
            // 
            fincomboBox.FormattingEnabled = true;
            fincomboBox.Location = new Point(91, 206);
            fincomboBox.Name = "fincomboBox";
            fincomboBox.Size = new Size(207, 28);
            fincomboBox.TabIndex = 2;
            // 
            // titulolabel
            // 
            titulolabel.AutoSize = true;
            titulolabel.Location = new Point(91, 37);
            titulolabel.Name = "titulolabel";
            titulolabel.Size = new Size(179, 20);
            titulolabel.TabIndex = 3;
            titulolabel.Text = "NOMBRE DE LA MATERIA";
            // 
            // iniciolabel
            // 
            iniciolabel.AutoSize = true;
            iniciolabel.Location = new Point(375, 37);
            iniciolabel.Name = "iniciolabel";
            iniciolabel.Size = new Size(121, 20);
            iniciolabel.TabIndex = 4;
            iniciolabel.Text = "Horario de inicio";
            // 
            // finlabel
            // 
            finlabel.AutoSize = true;
            finlabel.Location = new Point(129, 172);
            finlabel.Name = "finlabel";
            finlabel.Size = new Size(84, 20);
            finlabel.TabIndex = 5;
            finlabel.Text = "Hora de fin";
            // 
            // guardarbutton
            // 
            guardarbutton.Location = new Point(255, 293);
            guardarbutton.Name = "guardarbutton";
            guardarbutton.Size = new Size(111, 58);
            guardarbutton.TabIndex = 6;
            guardarbutton.Text = "GUARDAR";
            guardarbutton.UseVisualStyleBackColor = true;
            guardarbutton.Click += guardarbutton_Click;
            // 
            // ampmlabel
            // 
            ampmlabel.AutoSize = true;
            ampmlabel.Location = new Point(456, 172);
            ampmlabel.Name = "ampmlabel";
            ampmlabel.Size = new Size(62, 20);
            ampmlabel.TabIndex = 7;
            ampmlabel.Text = "AM/P.M";
            // 
            // ampmcomboBox
            // 
            ampmcomboBox.FormattingEnabled = true;
            ampmcomboBox.Location = new Point(375, 206);
            ampmcomboBox.Name = "ampmcomboBox";
            ampmcomboBox.Size = new Size(207, 28);
            ampmcomboBox.TabIndex = 8;
            // 
            // materiatextBox
            // 
            materiatextBox.Location = new Point(91, 76);
            materiatextBox.Name = "materiatextBox";
            materiatextBox.Size = new Size(193, 27);
            materiatextBox.TabIndex = 9;
            // 
            // materiaslistBox
            // 
            materiaslistBox.FormattingEnabled = true;
            materiaslistBox.ItemHeight = 20;
            materiaslistBox.Location = new Point(12, 379);
            materiaslistBox.Name = "materiaslistBox";
            materiaslistBox.Size = new Size(668, 184);
            materiaslistBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 584);
            Controls.Add(materiaslistBox);
            Controls.Add(materiatextBox);
            Controls.Add(ampmcomboBox);
            Controls.Add(ampmlabel);
            Controls.Add(guardarbutton);
            Controls.Add(finlabel);
            Controls.Add(iniciolabel);
            Controls.Add(titulolabel);
            Controls.Add(fincomboBox);
            Controls.Add(iniciocomboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox iniciocomboBox;
        private ComboBox comboBox2;
        private ComboBox fincomboBox;
        private Label titulolabel;
        private Label iniciolabel;
        private Label finlabel;
        private Button guardarbutton;
        private Label ampmlabel;
        private ComboBox ampmcomboBox;
        private TextBox materiatextBox;
        private ListBox materiaslistBox;
    }
}
namespace interesCompuestoUI.Forms
{
    partial class interesCompuesto
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.montoInicialLabel = new System.Windows.Forms.Label();
            this.montoInicialTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(14, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(215, 31);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Interes Compuesto";
            // 
            // montoInicialLabel
            // 
            this.montoInicialLabel.AutoSize = true;
            this.montoInicialLabel.Location = new System.Drawing.Point(14, 60);
            this.montoInicialLabel.Name = "montoInicialLabel";
            this.montoInicialLabel.Size = new System.Drawing.Size(164, 31);
            this.montoInicialLabel.TabIndex = 1;
            this.montoInicialLabel.Text = "Monto Inicial:";
            // 
            // montoInicialTextBox
            // 
            this.montoInicialTextBox.Location = new System.Drawing.Point(14, 94);
            this.montoInicialTextBox.Name = "montoInicialTextBox";
            this.montoInicialTextBox.Size = new System.Drawing.Size(215, 38);
            this.montoInicialTextBox.TabIndex = 2;
            // 
            // porcentajeTextBox
            // 
            this.porcentajeTextBox.Location = new System.Drawing.Point(14, 195);
            this.porcentajeTextBox.Name = "porcentajeTextBox";
            this.porcentajeTextBox.Size = new System.Drawing.Size(215, 38);
            this.porcentajeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Porcentaje:";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(14, 256);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(215, 47);
            this.calcularButton.TabIndex = 5;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(14, 334);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(0, 31);
            this.resultadoLabel.TabIndex = 6;
            // 
            // interesCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 391);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.porcentajeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.montoInicialTextBox);
            this.Controls.Add(this.montoInicialLabel);
            this.Controls.Add(this.tituloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "interesCompuesto";
            this.Text = "interesCompuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tituloLabel;
        private Label montoInicialLabel;
        private TextBox montoInicialTextBox;
        private TextBox porcentajeTextBox;
        private Label label1;
        private Button calcularButton;
        private Label resultadoLabel;
    }
}
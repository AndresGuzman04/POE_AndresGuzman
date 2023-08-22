namespace practica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.campo1TextBox = new System.Windows.Forms.TextBox();
            this.campo2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // campo1TextBox
            // 
            this.campo1TextBox.Location = new System.Drawing.Point(18, 34);
            this.campo1TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.campo1TextBox.Name = "campo1TextBox";
            this.campo1TextBox.Size = new System.Drawing.Size(164, 26);
            this.campo1TextBox.TabIndex = 1;
            // 
            // campo2TextBox
            // 
            this.campo2TextBox.Location = new System.Drawing.Point(18, 97);
            this.campo2TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.campo2TextBox.Name = "campo2TextBox";
            this.campo2TextBox.Size = new System.Drawing.Size(164, 26);
            this.campo2TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto:";
            // 
            // validarButton
            // 
            this.validarButton.Location = new System.Drawing.Point(18, 131);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(164, 31);
            this.validarButton.TabIndex = 4;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 197);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.campo2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campo1TextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campo1TextBox;
        private System.Windows.Forms.TextBox campo2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validarButton;
    }
}


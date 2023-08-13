namespace ejercicio_2
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
            this.respuesta = new System.Windows.Forms.Label();
            this.enterbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Location = new System.Drawing.Point(298, 222);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(118, 16);
            this.respuesta.TabIndex = 2;
            this.respuesta.Text = "Presione una tecla";
            this.respuesta.Click += new System.EventHandler(this.respuesta_Click);
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(273, 193);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(111, 26);
            this.enterbutton.TabIndex = 0;
            this.enterbutton.Text = "Presione una tecla";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            this.enterbutton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterbutton_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.enterbutton);
            this.Name = "Form1";
            this.Text = "lo que se utilizo fue:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Button enterbutton;
    }
}

